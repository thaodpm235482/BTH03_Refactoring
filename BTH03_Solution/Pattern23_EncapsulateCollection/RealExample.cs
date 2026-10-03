namespace Pattern23_EncapsulateCollection
{
    public class RealExample
    {
        public void Run()
        {
            AfterCode student = new AfterCode();
            student.AddCourse("Lap trinh C#");
            student.AddCourse("Co so du lieu");

            System.Console.WriteLine($"So luong khoa hoc: {student.Courses.Count}");
        }
    }
}