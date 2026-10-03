namespace Pattern11_MoveField._1_Before
{
    public class AccountType
    {
    }

    public class Account
    {
        private AccountType _type;
        private double _interestRate;

        public double InterestRate
        {
            get => _interestRate;
            set => _interestRate = value;
        }
    }
}