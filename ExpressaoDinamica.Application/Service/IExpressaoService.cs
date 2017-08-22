using ExpressaoDinamica.Application.DTO;
using System.Collections.Generic;

namespace ExpressaoDinamica.Application.Service
{
    public interface IExpressaoService
    {
        List<ValueObject> CalcularExpressao(List<ValueObject> data, string expressao);
    }
}
