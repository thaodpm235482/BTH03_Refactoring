using System;

namespace Pattern30_ReplaceConditionalWithPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 30: REPLACE CONDITIONAL WITH POLYMORPHISM ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}