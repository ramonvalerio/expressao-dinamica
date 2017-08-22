using System;

namespace ExpressaoDinamica.Application.DTO
{
    public class ValueObject
    {
        public DateTime? Date { get; private set; }

        public double? Value { get; private set; }

        public double? Result { get; set; }

        public string InterpretedFormula { get; set; }

        private ValueObject()
        {

        }

        public ValueObject(DateTime? date, double? value)
        {
            Date = date;
            Value = value;
        }
    }
}