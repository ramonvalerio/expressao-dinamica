using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using NCalc;
using ExpressaoDinamica.Application.DTO;
using System.Collections.Generic;
using ExpressaoDinamica.Infrastructure.Repository;
using ExpressaoDinamica.Domain.Model;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExpressaoDinamica.Application.Service
{
    public class ExpressaoAppService : IExpressaoAppService
    {
        private readonly ScriptEngine _engine = Python.CreateEngine();
        public readonly IFunctionRepository _functionRepository;
        private int _index;
        private List<ValueObject> _data { get; set; }

        public ExpressaoAppService()
        {
            _functionRepository = new FunctionRepository();
        }

        public List<ValueObject> CalcularExpressao(List<ValueObject> data, string expressao)
        {
            _data = data.Select(x => { x.Result = null; return x; }).ToList();

            try
            {
                var expressions = getFunctionsByFormula(expressao);

                foreach (var item in _data)
                {
                    var e = new Expression(expressao);
                    e.EvaluateFunction += E_EvaluateFunction;
                    e.EvaluateParameter += E_EvaluateParameter;

                    item.InterpretedFormula = expressao;
                    item.Result = Math.Round(Convert.ToDouble(e.Evaluate()), 2);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _index = 0;
            }

            return data;
        }

        private List<Expression> getFunctionsByFormula(string input)
        {
            input = "A(B(C(X)))";
            var pattern = @"\b[^()]+\((.*)\)$";
            var regex = new Regex(pattern, RegexOptions.None);

            var result = new List<Expression>();
            var functions = new List<string>();

            do
            {
                functions.Add(input);
                input = regex.Split(input).SingleOrDefault(x => x != string.Empty);
            } while (regex.IsMatch(input));

            for (int i = 0; i < functions.Count; i++)
            {
                var functionFormat = string.Empty;

                if ((i + 1) < functions.Count)
                    functionFormat = functions[i].Replace(functions[i + 1], "X");
                else
                    functionFormat = functions[i];
                
                var expression = new Expression(functionFormat);
                expression.EvaluateFunction += E_EvaluateFunction;
                expression.EvaluateParameter += E_EvaluateParameter;
                result.Add(expression);
            }

            return result;
        }

        public List<Function> GetAllFunctions()
        {
            return _functionRepository.GetAllFunctions();
        }

        public void AddFunction(string name, string formula, int amountParameters)
        {
            _functionRepository.AddFunction(name, formula, amountParameters);
        }

        private FunctionDTO GetFunctionByName(string name)
        {
            var function = _functionRepository.GetFunctionByName(name);
            return new FunctionDTO { Name = function.Name, Formula = function.Formula, AmountParameters = function.AmountParameters };
        }

        private void E_EvaluateParameter(string name, ParameterArgs args)
        {
            if (_data[_index].Result == null)
            {
                args.Result = _data[_index].Value;
                _index++;
                return;
            }

            args.Result = _data[_index].Result;
            _index++;
        }

        private void E_EvaluateFunction(string name, FunctionArgs args)
        {
            var function = _functionRepository.GetFunctionByName(name);

            if (function == null)
                throw new Exception(string.Format("Função {0} não existe.", name));

            var total = args.Parameters.Count();

            // Calcula B
            //for (int i = 0; i < total; i++)
            //{
            //    args.Parameters[i] = new Expression(args.Parameters[i].ParsedExpression);
            //}

            //args.Result = Convert.ToDouble(args.Parameters[total - 1].Evaluate());

            // Calcula A
            //var e = new Expression(function.Formula);
            //e.EvaluateFunction += E_EvaluateFunction;
            //e.EvaluateParameter += E_EvaluateParameter;
            //args.Result = Convert.ToDouble(e.Evaluate());
        }
    }
}
