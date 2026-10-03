namespace Pattern30_ReplaceConditionalWithPolymorphism
{
    public class BeforeCode
    {
        public double GetPayAmount(int type, double monthlySalary, double commission, double bonus)
        {
            switch (type)
            {
                case 0: return monthlySalary;
                case 1: return monthlySalary + commission;
                case 2: return monthlySalary + bonus;
                default: return 0;
            }
        }
    }
}