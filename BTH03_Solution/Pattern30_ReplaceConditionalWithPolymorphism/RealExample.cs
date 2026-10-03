namespace Pattern30_ReplaceConditionalWithPolymorphism
{
    public class RealExample
    {
        public void Run()
        {
            Employee emp = new Salesman();
            System.Console.WriteLine($"Luong cua Salesman (Da hinh): {emp.GetPayAmount()}");
        }
    }
}