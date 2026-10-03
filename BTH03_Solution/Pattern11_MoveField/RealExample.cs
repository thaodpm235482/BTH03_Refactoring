using System;

namespace Pattern11_MoveField._3_Real
{
    public class MembershipClass
    {
        public string Name { get; set; } = "VIP";
        public double DiscountPercent { get; set; } = 0.15; // 15%
    }

    public class Customer
    {
        public string FullName { get; set; }
        public MembershipClass Membership { get; set; }

        public Customer(string name, MembershipClass membership)
        {
            FullName = name;
            Membership = membership;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Khách hàng: {FullName} | Hạng: {Membership.Name} | Giảm giá: {Membership.DiscountPercent * 100}%");
        }
    }

    internal class RealExample
    {
        public void Run()
        {
            MembershipClass vip = new MembershipClass();
            Customer cus = new Customer("Nguyễn Văn A", vip);
            cus.DisplayInfo();
        }
    }
}