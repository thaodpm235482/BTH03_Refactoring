using System;
using Pattern08_ReplaceMethodWithMethodObject._1_Before;
using Pattern08_ReplaceMethodWithMethodObject._2_After;
using Pattern08_ReplaceMethodWithMethodObject._3_Real;

namespace Pattern08_ReplaceMethodWithMethodObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE ---");
            _1_Before.BeforeCode before = new _1_Before.BeforeCode();
            Console.WriteLine($"Tính toán: {before.Price(100, 60, 0.1)}");

            Console.WriteLine("\n--- 2. AFTER ---");
            _2_After.BeforeCode after = new _2_After.BeforeCode();
            Console.WriteLine($"Tính toán: {after.Price(100, 60, 0.1)}");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.ProcessLoan(20000000, 9000000);

            Console.ReadLine();
        }
    }
}