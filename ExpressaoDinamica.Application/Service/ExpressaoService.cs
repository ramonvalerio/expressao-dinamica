using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;

namespace ExpressaoDinamica.Application.Service
{
    public class ExpressaoService : IExpressaoService
    {
        private readonly ScriptEngine _engine = Python.CreateEngine();
        public TNumber CalcularExpressaoFromPython<TNumber>(string expressao)
        {
            return _engine.CreateScriptSourceFromString(expressao, SourceCodeKind.Expression).Execute<TNumber>();
        }
        public TNumber CalcularExpressaoFromNCalc<TNumber>(string expressao)
        {
            throw new NotImplementedException();
        }
    }
}
