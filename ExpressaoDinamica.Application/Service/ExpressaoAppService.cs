using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using NCalc;
using ExpressaoDinamica.Application.DTO;
using System.Collections.Generic;
using ExpressaoDinamica.Infrastructure.Repository;
using ExpressaoDinamica.Domain.Model;
using System.Linq;

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

            //Chamada do Python
            //return _engine.CreateScriptSourceFromString(expressao, SourceCodeKind.Expression).Execute<TNumber>();

            try
            {
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

            //var formulaChild = args.Parameters[0].ParsedExpression.ToString().Replace("[", "").Replace("]", "");
            //var e = new Expression(formulaChild);

            var e = new Expression(function.Formula);
            e.EvaluateFunction += E_EvaluateFunction;
            e.EvaluateParameter += E_EvaluateParameter;
            args.Result = Convert.ToDouble(e.Evaluate());

            //switch (name)
            //{
            //    case "exp":
            //        args.Result = Math.Exp(Convert.ToDouble(args.Parameters[0].Evaluate()));
            //        break;
            //}
        }
    }
}
