using System;

namespace Pattern01_ExtractMethod._2_After
{
    public class AfterCode
    {
        // Hàm sau khi đã áp dụng Extract Method
        public void PrintOwing(string name, double amount)
        {
            PrintBanner();
            PrintDetails(name, amount);
        }

        // Tách logic in tiêu đề thành hàm riêng
        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("***** Customer Owes ***");
            Console.WriteLine("***********************");
        }

        // Tách logic in chi tiết thành hàm riêng
        private void PrintDetails(string name, double amount)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}$");
        }
    }
}