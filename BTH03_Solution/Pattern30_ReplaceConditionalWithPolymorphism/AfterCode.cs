namespace Pattern30_ReplaceConditionalWithPolymorphism
{
    public abstract class Employee
    {
        public double MonthlySalary { get; set; } = 1000;
        public double Commission { get; set; } = 200;
        public double Bonus { get; set; } = 500;

        public abstract double GetPayAmount();
    }

    public class Engineer : Employee
    {
        public override double GetPayAmount() => MonthlySalary;
    }

    public class Salesman : Employee
    {
        public override double GetPayAmount() => MonthlySalary + Commission;
    }

    public class Manager : Employee
    {
        public override double GetPayAmount() => MonthlySalary + Bonus;
    }
}