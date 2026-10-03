namespace Pattern12_ExtractClass._2_After
{
    // Tách riêng thông tin số điện thoại thành Class TelephoneNumber
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }

        public string GetFullNumber() => $"({AreaCode}) {Number}";
    }

    public class Person
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();

        public string GetTelephoneNumber() => Phone.GetFullNumber();
    }
}