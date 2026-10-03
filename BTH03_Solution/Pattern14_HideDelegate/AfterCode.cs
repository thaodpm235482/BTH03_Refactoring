namespace Pattern14_HideDelegate._2_After
{
    public class Department
    {
        public Person Manager { get; set; }
    }

    public class Person
    {
        private Department _department;

        public Department Department { set => _department = value; }

        // Ẩn việc truy xuất Department qua hàm ủy thác GetManager()
        public Person GetManager()
        {
            return _department.Manager;
        }
    }
}