using System;

namespace Pattern07_RemoveAssignmentsToParameters._3_Real
{
    internal class RealExample
    {
        public double CalculateFinalBalance(double initialBalance, double deposit, double withdrawal)
        {
            double currentBalance = initialBalance;
            currentBalance += deposit;
            currentBalance -= withdrawal;

            Console.WriteLine($"Số dư ban đầu giữ nguyên: {initialBalance:N0} VNĐ");
            Console.WriteLine($"Số dư sau giao dịch: {currentBalance:N0} VNĐ");
            return currentBalance;
        }
    }
}
