namespace Pattern29_ReplaceTypeCodeWithStateStrategy
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode emp = new AfterCode(new EngineerType());
            System.Console.WriteLine($"Ma loai nhan vien (Strategy/State): {emp.Type.GetTypeCode()}");
        }
    }
}