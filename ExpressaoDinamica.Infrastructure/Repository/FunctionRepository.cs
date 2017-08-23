using ExpressaoDinamica.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace ExpressaoDinamica.Infrastructure.Repository
{
    public class FunctionRepository : IFunctionRepository
    {
        private readonly Dictionary<string, Function> _functions = new Dictionary<string, Function>();

        public void AddFunction(string name, string formula, int amountParameters)
        {
            if (_functions.ContainsKey(name))
                return;

            _functions.Add(name, new Function { Name = name, Formula = formula, AmountParameters = amountParameters });
        }

        public List<Function> GetAllFunctions()
        {
            return _functions.Values.ToList();
        }

        public Function GetFunctionByName(string name)
        {
            if (!_functions.ContainsKey(name))
                return null;

            return _functions[name];
        }
    }
}