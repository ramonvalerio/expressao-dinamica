using ExpressaoDinamica.Domain.Model;

namespace ExpressaoDinamica.Infrastructure.Repository
{
    public interface IFunctionRepository
    {
        void AddFunction(string name, string formula, int amountParameters);

        Function GetFunctionByName(string name);
    }
}