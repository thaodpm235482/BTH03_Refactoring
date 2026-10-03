namespace Pattern27_ReplaceTypeCodeWithClass
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode person = new AfterCode(BloodGroup.O);
            System.Console.WriteLine($"Nhom mau nhan vien: {person.BloodGroup.Code}");
        }
    }
}