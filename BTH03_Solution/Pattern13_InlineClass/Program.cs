using System;
using Pattern13_InlineClass._3_Real;

namespace Pattern13_InlineClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 13: INLINE CLASS ===");

            RealExample real = new RealExample();
            real.Run();

            Console.ReadLine();
        }
    }
}