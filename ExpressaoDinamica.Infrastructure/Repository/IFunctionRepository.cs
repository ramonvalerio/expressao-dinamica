using ExpressaoDinamica.Domain.Model;
using System.Collections.Generic;

namespace ExpressaoDinamica.Infrastructure.Repository
{
    public interface IFunctionRepository
    {
        void Save(Function function);

        Function GetFunctionByName(string name);

        List<Function> GetAllFunctions();

        void Remove(string name);
    }
}