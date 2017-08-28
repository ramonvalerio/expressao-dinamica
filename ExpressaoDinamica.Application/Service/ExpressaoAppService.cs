using ExpressaoDinamica.Application.DTO;
using ExpressaoDinamica.Domain.Model;
using ExpressaoDinamica.Infrastructure.Repository;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using NCalc;
using System;
using System.Collections.Generic;
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
                    foreach (var e in expressions)
                    {
                        var result = e.Evaluate();
                        item.Result = Math.Round(Convert.ToDouble(result), 2);
                    }

                    _index++;
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
            //var pattern = @"\b[^()]+\((.*)\)$";
            var pattern = @"(?<single>[A-z]+\s*\(\s*[A-z]+(,\s*[A-z])?\s*\))|(?<composition>[A-z]+\s*\(\s*[A-z]+\s*\(\s*[A-z]\s*\)\s*\))";
            var regex = new Regex(pattern, RegexOptions.None);

            var result = new List<Expression>();
            var functions = new List<string>();

            var matchesResult = regex.Matches(input);

            foreach (Match item in matchesResult)
            {
                functions.Add(item.Value);
            }

            for (int i = 0; i < functions.Count; i++)
            {
                var expression = new Expression(functions[i].Replace(" ", ""));
                expression.EvaluateFunction += E_EvaluateFunction;
                expression.EvaluateParameter += E_EvaluateParameter;
                result.Add(expression);
            }

            result.Reverse();

            return result;
        }

        public List<Function> GetAllFunctions()
        {
            return _functionRepository.GetAllFunctions();
        }

        public void AddFunction(string name, string formula, int amountParameters)
        {
            var function = new Function();
            function.Name = name;
            function.Formula = formula;
            function.AmountParameters = amountParameters;
            _functionRepository.Save(function);
        }

        private FunctionDTO GetFunctionByName(string name)
        {
            var function = _functionRepository.GetFunctionByName(name);
            return new FunctionDTO { Name = function.Name, Formula = function.Formula, AmountParameters = function.AmountParameters };
        }

        private void E_EvaluateParameter(string name, ParameterArgs args)
        {
            if (_data[_index].Result == null)
                args.Result = _data[_index].Value;
            else
                args.Result = _data[_index].Result;
        }

        private void E_EvaluateFunction(string name, FunctionArgs args)
        {
            var function = _functionRepository.GetFunctionByName(name);

            if (function == null)
                throw new Exception(string.Format("Função {0} não existe.", name));

            if (function.AmountParameters != args.Parameters.Count())
                throw new Exception(string.Format("Função {0} com quantidade de parâmetros inválido.", name));

            foreach (var item in args.Parameters)
            {
                if (item.ParsedExpression != null)
                {
                    var pattern = @"(?<single>[A-z]+\s*\(\s*[A-z]+(,\s*[A-z])?\s*\))|(?<composition>[A-z]+\s*\(\s*[A-z]+\s*\(\s*[A-z]\s*\)\s*\))";
                    var regex = new Regex(pattern, RegexOptions.None);

                    if (regex.IsMatch(item.ParsedExpression.ToString()))
                    {
                        var e2 = new Expression(item.ParsedExpression);
                        e2.EvaluateFunction += E_EvaluateFunction;
                        e2.EvaluateParameter += E_EvaluateParameter;
                        _data[_index].Result = Convert.ToDouble(e2.Evaluate());
                    }
                    else
                    {
                        var e2 = new Expression(function.Formula);
                        e2.EvaluateFunction += E_EvaluateFunction;
                        e2.EvaluateParameter += E_EvaluateParameter;
                        _data[_index].Result = Convert.ToDouble(e2.Evaluate());
                    }
                }
            }

            var e = new Expression(function.Formula);
            e.EvaluateFunction += E_EvaluateFunction;
            e.EvaluateParameter += E_EvaluateParameter;
            args.Result = Convert.ToDouble(e.Evaluate());
        }
    }
}