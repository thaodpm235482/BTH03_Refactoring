namespace Pattern13_InlineClass._1_Before
{
    // Class TelephoneNumber quá ít chức năng, không cần thiết giữ riêng
    public class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; set; } = new TelephoneNumber();
    }
}