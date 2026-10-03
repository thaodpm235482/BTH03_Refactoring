using System;

namespace Pattern24_DecomposeConditional
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode calc = new AfterCode();
            double charge = calc.CalculateCharge(new DateTime(2026, 7, 15), 10);
            System.Console.WriteLine($"Chi phi mua he: {charge}");
        }
    }
}