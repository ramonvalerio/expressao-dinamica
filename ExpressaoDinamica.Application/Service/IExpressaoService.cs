namespace ExpressaoDinamica.Application.Service
{
    public interface IExpressaoService
    {
        TNumber CalcularExpressaoFromPython<TNumber>(string expressao);

        double CalcularExpressaoFromNCalc(string expressao);
    }
}
