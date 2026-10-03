namespace Pattern11_MoveField._2_After
{
    public class AccountType
    {
        // Di chuyển trường InterestRate sang AccountType
        public double InterestRate { get; set; }
    }

    public class Account
    {
        private AccountType _type;

        public Account(AccountType type)
        {
            _type = type;
        }

        public double InterestRate
        {
            get => _type.InterestRate;
            set => _type.InterestRate = value;
        }
    }
}