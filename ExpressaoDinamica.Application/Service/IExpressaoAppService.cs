﻿using ExpressaoDinamica.Application.DTO;
using System.Collections.Generic;

namespace ExpressaoDinamica.Application.Service
{
    public interface IExpressaoAppService
    {
        List<ValueObject> CalcularExpressao(List<ValueObject> data, string expressao);

        void AddFunction(string name, string formula, int amountParameters);
    }
}