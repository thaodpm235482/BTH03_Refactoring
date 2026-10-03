namespace Pattern25_ConsolidateConditionalExpression
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode calc = new AfterCode();
            double amount = calc.DisabilityAmount(3, 5, false);
            System.Console.WriteLine($"Tien tro cap: {amount}");
        }
    }
}