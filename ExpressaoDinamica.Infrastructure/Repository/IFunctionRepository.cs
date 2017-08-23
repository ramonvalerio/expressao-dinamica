using ExpressaoDinamica.Domain.Model;
using System.Collections.Generic;

namespace ExpressaoDinamica.Infrastructure.Repository
{
    public interface IFunctionRepository
    {
        void AddFunction(string name, string formula, int amountParameters);

        Function GetFunctionByName(string name);

        List<Function> GetAllFunctions();
    }
}