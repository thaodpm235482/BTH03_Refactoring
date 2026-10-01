using System;
using Pattern05_ReplaceTempWithQuery._1_Before;
using Pattern05_ReplaceTempWithQuery._2_After;
using Pattern05_ReplaceTempWithQuery._3_Real;

namespace Pattern05_ReplaceTempWithQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE ---");
            BeforeCode before = new BeforeCode();
            Console.WriteLine($"Tổng tiền: {before.CalculateTotal():N0}");

            Console.WriteLine("\n--- 2. AFTER ---");
            AfterCode after = new AfterCode();
            Console.WriteLine($"Tổng tiền: {after.CalculateTotal():N0}");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.DisplaySalaryInfo();

            Console.ReadLine();
        }
    }
}