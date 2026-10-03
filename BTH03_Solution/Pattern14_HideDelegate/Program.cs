using System;
using Pattern14_HideDelegate._3_Real;

namespace Pattern14_HideDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 14: HIDE DELEGATE ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}