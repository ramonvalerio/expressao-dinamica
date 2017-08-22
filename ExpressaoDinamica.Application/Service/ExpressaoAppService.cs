using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using NCalc;
using ExpressaoDinamica.Application.DTO;
using System.Collections.Generic;
using ExpressaoDinamica.Infrastructure.Repository;

namespace ExpressaoDinamica.Application.Service
{
    public class ExpressaoAppService : IExpressaoAppService
    {
        private readonly ScriptEngine _engine = Python.CreateEngine();
        private readonly IFunctionRepository _functionRepository = new FunctionRepository();

        public List<ValueObject> CalcularExpressao(List<ValueObject> data, string expressao)
        {
            //Chamada do Python
            //return _engine.CreateScriptSourceFromString(expressao, SourceCodeKind.Expression).Execute<TNumber>();

            foreach (var item in data)
            {
                var e = new Expression(expressao);
                e.EvaluateFunction += E_EvaluateFunction;
                e.EvaluateParameter += E_EvaluateParameter;

                item.Result = Convert.ToDouble(e.Evaluate());
                item.InterpretedFormula = expressao;
            }

            return data;
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
            
        }

        private void E_EvaluateFunction(string name, FunctionArgs args)
        {
            var function = _functionRepository.GetFunctionByName(name);

            if (function == null)
                throw new Exception(string.Format("Função {0} não existe.", name));

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
