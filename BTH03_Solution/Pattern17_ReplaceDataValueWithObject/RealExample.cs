using System;

namespace Pattern17_ReplaceDataValueWithObject._3_Real
{
    public class PhoneNumber
    {
        public string Number { get; }
        public PhoneNumber(string number) => Number = number;
    }

    public class User
    {
        public string Name { get; set; } = "Trần Văn B";
        public PhoneNumber Phone { get; set; } = new PhoneNumber("0901234567");

        public void PrintDetails()
        {
            Console.WriteLine($"Người dùng: {Name} | SĐT: {Phone.Number}");
        }
    }

    internal class RealExample
    {
        public void Run()
        {
            User user = new User();
            user.PrintDetails();
        }
    }
}