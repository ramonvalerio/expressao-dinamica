using ExpressaoDinamica.Domain.Model;
using System.Collections.Generic;

namespace ExpressaoDinamica.Infrastructure.Repository
{
    public class FunctionRepository : IFunctionRepository
    {
        private readonly Dictionary<string, Function> _functionsDTO = new Dictionary<string, Function>();

        public void AddFunction(string name, string formula, int amountParameters)
        {
            if (!_functionsDTO.ContainsKey(name))
                return;

            _functionsDTO.Add(name, new Function { Name = name, Formula = formula, AmountParameters = amountParameters });
        }

        public Function GetFunctionByName(string name)
        {
            if (!_functionsDTO.ContainsKey(name))
                return null;

            return _functionsDTO[name];
        }
    }
}