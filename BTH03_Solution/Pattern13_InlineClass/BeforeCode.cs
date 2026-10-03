namespace Pattern13_InlineClass._1_Before
{
    // Trước khi Refactoring: Class TelephoneNumber quá ít công việc, gây dư thừa
    public class TelephoneNumber
    {
        public string AreaCode { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;

        public string GetTelephoneNumber() => $"({AreaCode}) {Number}";
    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public TelephoneNumber OfficeTelephone { get; } = new TelephoneNumber();
    }
}