using System;
using Pattern15_RemoveMiddleMan._3_Real;

namespace Pattern15_RemoveMiddleMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 15: REMOVE MIDDLE MAN ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}