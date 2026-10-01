using System;
using Pattern07_RemoveAssignmentsToParameters._1_Before;
using Pattern07_RemoveAssignmentsToParameters._2_After;
using Pattern07_RemoveAssignmentsToParameters._3_Real;

namespace Pattern07_RemoveAssignmentsToParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE ---");
            BeforeCode before = new BeforeCode();
            Console.WriteLine($"Kết quả giảm giá: {before.Discount(60, 120)}");

            Console.WriteLine("\n--- 2. AFTER ---");
            AfterCode after = new AfterCode();
            Console.WriteLine($"Kết quả giảm giá: {after.Discount(60, 120)}");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.CalculateFinalBalance(5000000, 2000000, 1500000);

            Console.ReadLine();
        }
    }
}