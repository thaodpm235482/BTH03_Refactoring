using System;
using Pattern20_ReplaceArrayWithObject._3_Real;

namespace Pattern20_ReplaceArrayWithObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 20: REPLACE ARRAY WITH OBJECT ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}