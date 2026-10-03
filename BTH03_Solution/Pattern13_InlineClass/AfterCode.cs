namespace Pattern13_InlineClass._2_After
{
    // Sau khi Refactoring (Inline Class): Gộp trực tiếp các thuộc tính số điện thoại vào Person
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public string AreaCode { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;

        public string GetTelephoneNumber() => $"({AreaCode}) {Number}";
    }
}