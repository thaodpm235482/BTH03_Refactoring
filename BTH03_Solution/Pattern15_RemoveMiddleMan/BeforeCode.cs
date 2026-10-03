namespace Pattern15_RemoveMiddleMan._1_Before
{
    public class Department
    {
        public Person Manager { get; set; }
    }

    public class Person
    {
        private Department _department = new Department();

        // Lớp Person đóng vai trò trung gian quá nhiều hàm chỉ để gọi gián tiếp Department
        public Person GetManager() => _department.Manager;
    }
}