using System;
using Pattern19_ChangeReferenceToValue._3_Real;

namespace Pattern19_ChangeReferenceToValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PATTERN 19: CHANGE REFERENCE TO VALUE ===");
            RealExample real = new RealExample();
            real.Run();
            Console.ReadLine();
        }
    }
}