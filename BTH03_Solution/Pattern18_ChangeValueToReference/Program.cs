using System;
using Pattern18_ChangeValueToReference._3_Real;

namespace Pattern18_ChangeValueToReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 18: CHANGE VALUE TO REFERENCE ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}