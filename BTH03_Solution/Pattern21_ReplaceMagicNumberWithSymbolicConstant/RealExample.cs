namespace Pattern21_ReplaceMagicNumberWithSymbolicConst
{
    public class RealExample
    {
        private const double StandardTaxRate = 0.10; // 10% VAT

        public double CalculateTotalWithTax(double price)
        {
            return price + (price * StandardTaxRate);
        }

        public void Run()
        {
            double itemPrice = 100.0;
            System.Console.WriteLine($"Gia sau thue (10% VAT): {CalculateTotalWithTax(itemPrice)}");
        }
    }
}