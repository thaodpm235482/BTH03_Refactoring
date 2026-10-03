using System;

namespace Pattern12_ExtractClass._3_Real
{
    public class Address
    {
        public string Street { get; set; } = "123 Lê Lợi";
        public string City { get; set; } = "TP. Hồ Chí Minh";
        public string GetFullAddress() => $"{Street}, {City}";
    }

    public class Company
    {
        public string CompanyName { get; set; } = "Công ty Công Nghệ ABC";
        public Address CompanyAddress { get; set; } = new Address();

        public void PrintCompanyDetails()
        {
            Console.WriteLine($"Tên công ty: {CompanyName}");
            Console.WriteLine($"Địa chỉ: {CompanyAddress.GetFullAddress()}");
        }
    }

    internal class RealExample
    {
        public void Run()
        {
            Company company = new Company();
            company.PrintCompanyDetails();
        }
    }
}