using System;

namespace Pattern10_MoveMethod._2_After
{
    public class AccountType
    {
        public bool IsPremium { get; set; } = true;

        // Di chuyển logic tính phí vượt hạn mức sang đúng Class chủ quản của nó
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                return 10.0;
            }
            return daysOverdrawn * 1.75;
        }
    }

    public class BankAccount
    {
        public AccountType Type { get; set; } = new AccountType();
        public int DaysOverdrawn { get; set; } = 5;

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
            {
                result += Type.OverdraftCharge(DaysOverdrawn);
            }
            return result;
        }
    }
}