namespace ExpressaoDinamica.Application.Service
{
    public interface IExpressaoService
    {
        TNumber CalcularExpressaoFromPython<TNumber>(string expressao);

        TNumber CalcularExpressaoFromNCalc<TNumber>(string expressao);
    }
}
