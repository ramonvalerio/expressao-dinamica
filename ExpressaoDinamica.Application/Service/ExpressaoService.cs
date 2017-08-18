using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using NCalc;
using System.Linq;

namespace ExpressaoDinamica.Application.Service
{
    public class ExpressaoService : IExpressaoService
    {
        private readonly ScriptEngine _engine = Python.CreateEngine();

        public TNumber CalcularExpressaoFromPython<TNumber>(string expressao)
        {
            return _engine.CreateScriptSourceFromString(expressao, SourceCodeKind.Expression).Execute<TNumber>();
        }
        public double CalcularExpressaoFromNCalc(string expressao)
        {
            var e = new Expression(expressao);
            e.EvaluateFunction += E_EvaluateFunction;
            return Convert.ToDouble(e.Evaluate());
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

        public double CalcularExpressaoFromCSharp(string expressao)
        {
            return Convert.ToDouble(2 + (3 * 5));
        }
    }
}
