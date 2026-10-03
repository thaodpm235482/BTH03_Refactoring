using System;
using Pattern16_SelfEncapsulateField._3_Real;

namespace Pattern16_SelfEncapsulateField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 16: SELF ENCAPSULATE FIELD ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}