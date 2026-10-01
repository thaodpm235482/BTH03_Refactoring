using System;
using Pattern06_SplitTemporaryVariable._1_Before;
using Pattern06_SplitTemporaryVariable._2_After;
using Pattern06_SplitTemporaryVariable._3_Real;

namespace Pattern06_SplitTemporaryVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE ---");
            BeforeCode before = new BeforeCode();
            before.CalculateGeometry(5, 10);

            Console.WriteLine("\n--- 2. AFTER ---");
            AfterCode after = new AfterCode();
            after.CalculateGeometry(5, 10);

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.CalculateTravelDistance(500, 100, 5);

            Console.ReadLine();
        }
    }
}