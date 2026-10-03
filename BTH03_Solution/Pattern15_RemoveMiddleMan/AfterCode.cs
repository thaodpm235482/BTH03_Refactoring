namespace Pattern15_RemoveMiddleMan._2_After
{
    public class Department
    {
        public Person Manager { get; set; }
    }

    public class Person
    {
        public Department Department { get; set; } = new Department();
        // Bỏ các hàm trung gian, cho phép lấy trực tiếp thuộc tính Department
    }
}