using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using NCalc;
using System.Linq;
using ExpressaoDinamica.Application.DTO;
using System.Collections.Generic;

namespace ExpressaoDinamica.Application.Service
{
    public class ExpressaoService : IExpressaoService
    {
        private readonly ScriptEngine _engine = Python.CreateEngine();

        public List<ValueObject> CalcularExpressao(List<ValueObject> data, string expressao)
        {
            //Chamada do Python
            //return _engine.CreateScriptSourceFromString(expressao, SourceCodeKind.Expression).Execute<TNumber>();

            foreach (var item in data)
            {
                var e = new Expression(expressao);
                e.EvaluateFunction += E_EvaluateFunction;

                item.Result = Convert.ToDouble(e.Evaluate());
            }

            return data;
        }

        private void E_EvaluateFunction(string name, FunctionArgs args)
        {
            switch (name)
            {
                case "exp":
                    args.Result = Math.Exp(Convert.ToDouble(args.Parameters[0].Evaluate()));
                    break;

                case "random":

                    var random = new Random();

                    if (args.Parameters.Count() == 0)
                    {
                        args.Result = random.Next();
                        return;
                    }

                    if (args.Parameters.Count() == 1)
                    {
                        var max = (int)args.Parameters[1].Evaluate();
                        args.Result = random.Next(max);
                        return;
                    }

                    if (args.Parameters.Count() == 2)
                    {
                        var min = (int)args.Parameters[0].Evaluate();
                        var max = (int)args.Parameters[1].Evaluate();
                        args.Result = random.Next(min, max);
                        return;
                    }

                    break;
            }
        }
    }
}
