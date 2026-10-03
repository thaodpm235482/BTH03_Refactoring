namespace Pattern22_EncapsulateField
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode person = new AfterCode();
            person.Name = "Nguyen Van A";
            System.Console.WriteLine($"Ten nhan vien: {person.Name}");
        }
    }
}