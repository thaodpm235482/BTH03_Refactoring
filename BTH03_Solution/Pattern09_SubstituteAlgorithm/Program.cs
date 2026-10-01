using System;
using Pattern09_SubstituteAlgorithm._1_Before;
using Pattern09_SubstituteAlgorithm._2_After;
using Pattern09_SubstituteAlgorithm._3_Real;

namespace Pattern09_SubstituteAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] list = { "Alice", "John", "Bob" };

            Console.WriteLine("--- 1. BEFORE ---");
            BeforeCode before = new BeforeCode();
            Console.WriteLine($"Tìm thấy: {before.FoundPerson(list)}");

            Console.WriteLine("\n--- 2. AFTER ---");
            AfterCode after = new AfterCode();
            Console.WriteLine($"Tìm thấy: {after.FoundPerson(list)}");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.ValidateUserRole("Manager");

            Console.ReadLine();
        }
    }
}