using ExpressaoDinamica.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace ExpressaoDinamica.Infrastructure.Repository
{
    public class FunctionRepository : IFunctionRepository
    {
        private readonly Dictionary<string, Function> _functions = new Dictionary<string, Function>();

        public void Save(Function function)
        {
            if (!_functions.ContainsKey(function.Name))
            {
                _functions.Add(function.Name, function);
            }
            else
            {
                _functions[function.Name] = function;
            }
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

        public void Remove(string name)
        {
            _functions.Remove(name);
        }
    }
}