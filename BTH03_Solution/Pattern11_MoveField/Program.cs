using System;
using Pattern11_MoveField._3_Real;

namespace Pattern11_MoveField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 11: MOVE FIELD ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}