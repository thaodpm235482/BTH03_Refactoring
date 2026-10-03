using System;

namespace Pattern24_DecomposeConditional
{
    public class BeforeCode
    {
        public double CalculateCharge(DateTime date, int quantity)
        {
            if (date.Month >= 6 && date.Month <= 8)
                return quantity * 15.0;
            else
                return quantity * 10.0 + 5.0;
        }
    }
}