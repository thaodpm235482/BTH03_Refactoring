using System;
using Pattern10_MoveMethod._1_Before;
using Pattern10_MoveMethod._2_After;
using Pattern10_MoveMethod._3_Real;

namespace Pattern10_MoveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- 1. BEFORE ---");
            _1_Before.BankAccount before = new _1_Before.BankAccount();
            Console.WriteLine($"Phí ngân hàng: {before.BankCharge()}$");

            Console.WriteLine("\n--- 2. AFTER ---");
            _2_After.BankAccount after = new _2_After.BankAccount();
            Console.WriteLine($"Phí ngân hàng: {after.BankCharge()}$");

            Console.WriteLine("\n--- 3. REAL EXAMPLE ---");
            RealExample real = new RealExample();
            real.ProcessShipping();

            Console.ReadLine();
        }
    }
}