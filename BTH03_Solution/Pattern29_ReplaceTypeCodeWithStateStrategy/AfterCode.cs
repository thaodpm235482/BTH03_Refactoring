namespace Pattern29_ReplaceTypeCodeWithStateStrategy
{
    public abstract class EmployeeType
    {
        public abstract int GetTypeCode();
    }

    public class EngineerType : EmployeeType
    {
        public override int GetTypeCode() => 0;
    }

    public class SalesmanType : EmployeeType
    {
        public override int GetTypeCode() => 1;
    }

    public class AfterCode
    {
        public EmployeeType Type { get; set; }

        public AfterCode(EmployeeType type)
        {
            Type = type;
        }
    }
}