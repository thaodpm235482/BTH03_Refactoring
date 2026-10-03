using System;

namespace Pattern28_ReplaceTypeCodeWithSubclasses
{
    public abstract class Employee
    {
        public abstract int GetTypeCode();

        public static Employee Create(int type)
        {
            return type switch
            {
                0 => new Engineer(),
                1 => new Salesman(),
                2 => new Manager(),
                _ => throw new ArgumentException("Loai nhan vien khong hop le")
            };
        }
    }

    public class Engineer : Employee
    {
        public override int GetTypeCode() => 0;
    }

    public class Salesman : Employee
    {
        public override int GetTypeCode() => 1;
    }

    public class Manager : Employee
    {
        public override int GetTypeCode() => 2;
    }
}