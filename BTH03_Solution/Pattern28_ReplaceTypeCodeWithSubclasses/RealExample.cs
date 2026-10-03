namespace Pattern28_ReplaceTypeCodeWithSubclasses
{
    public class RealExample
    {
        public void Run()
        {
            Employee emp = Employee.Create(0);
            System.Console.WriteLine($"Ma loai nhan vien (Engineer): {emp.GetTypeCode()}");
        }
    }
}