using System;
using Pattern01_ExtractMethod._1_Before;
using Pattern01_ExtractMethod._2_After;
using Pattern01_ExtractMethod._3_Real;

namespace Pattern01_ExtractMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Để in tiếng Việt không lỗi font

            Console.WriteLine("--- 1. BEFORE REFACTORING ---");
            BeforeCode before = new BeforeCode();
            before.PrintOwing("Nguyen Van A", 150.0);

            Console.WriteLine("\n--- 2. AFTER REFACTORING ---");
            AfterCode after = new AfterCode();
            after.PrintOwing("Nguyen Van A", 150.0);

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.ProcessOrder("Tran Thi B", 50000, 3);

            Console.ReadLine();
        }
    }
}