using System;
using Pattern12_ExtractClass._3_Real;

namespace Pattern12_ExtractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 12: EXTRACT CLASS ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}