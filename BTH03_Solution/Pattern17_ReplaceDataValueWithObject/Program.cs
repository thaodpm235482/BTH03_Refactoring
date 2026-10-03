using System;
using Pattern17_ReplaceDataValueWithObject._3_Real;

namespace Pattern17_ReplaceDataValueWithObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 17: REPLACE DATA VALUE WITH OBJECT ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}