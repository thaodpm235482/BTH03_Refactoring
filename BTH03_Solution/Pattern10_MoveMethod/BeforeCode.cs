using System;

namespace Pattern10_MoveMethod._1_Before
{
    public class AccountType
    {
        public bool IsPremium { get; set; } = true;
    }

    public class BankAccount
    {
        public AccountType Type { get; set; } = new AccountType();
        public int DaysOverdrawn { get; set; } = 5;

        // Phương thức này phụ thuộc quá nhiều vào dữ liệu của AccountType
        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0)
            {
                if (Type.IsPremium)
                {
                    result += 10.0;
                }
                else
                {
                    result += DaysOverdrawn * 1.75;
                }
            }
            return result;
        }
    }
}