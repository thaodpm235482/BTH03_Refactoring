using System;

namespace Pattern28_ReplaceTypeCodeWithSubclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 28: REPLACE TYPE CODE WITH SUBCLASSES ===");
            RealExample real = new RealExample();
            real.Run();
        }
    }
}