namespace Pattern14_HideDelegate._1_Before
{
    public class Department
    {
        public Person Manager { get; set; }
    }

    public class Person
    {
        public Department Department { get; set; }
    }

    // Client phải gọi person.Department.Manager (Lộ chi tiết liên kết)
}