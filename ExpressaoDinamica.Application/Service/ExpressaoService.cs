using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using NCalc;

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
            return Convert.ToDouble(e.Evaluate());
        }
        public double CalcularExpressaoFromCSharp(string expressao)
        {
            return 2 + (3 * 5);
        }
    }
}
