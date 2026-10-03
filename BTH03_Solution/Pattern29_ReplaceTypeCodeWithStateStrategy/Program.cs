using System;

namespace Pattern29_ReplaceTypeCodeWithStateStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 29: REPLACE TYPE CODE WITH STATE/STRATEGY ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}