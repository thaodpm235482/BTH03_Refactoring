using System;

namespace Pattern01_ExtractMethod._1_Before
{
    public class BeforeCode
    {
        // Hàm gốc chưa Refactor: Code ôm đơm quá nhiều việc
        public void PrintOwing(string name, double amount)
        {
            // In tiêu đề
            Console.WriteLine("***********************");
            Console.WriteLine("***** Customer Owes ***");
            Console.WriteLine("***********************");

            // In thông tin chi tiết
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}$");
        }
    }
}