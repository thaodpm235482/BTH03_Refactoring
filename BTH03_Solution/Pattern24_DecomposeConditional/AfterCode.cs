using System;

namespace Pattern24_DecomposeConditional
{
    public class AfterCode
    {
        public double CalculateCharge(DateTime date, int quantity)
        {
            if (IsSummer(date))
                return SummerCharge(quantity);
            return WinterCharge(quantity);
        }

        private bool IsSummer(DateTime date) => date.Month >= 6 && date.Month <= 8;
        private double SummerCharge(int quantity) => quantity * 15.0;
        private double WinterCharge(int quantity) => quantity * 10.0 + 5.0;
    }
}