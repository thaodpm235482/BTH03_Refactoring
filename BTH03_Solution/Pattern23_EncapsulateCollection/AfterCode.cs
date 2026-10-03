using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pattern23_EncapsulateCollection
{
    public class AfterCode
    {
        private readonly List<string> _courses = new List<string>();

        public ReadOnlyCollection<string> Courses => _courses.AsReadOnly();

        public void AddCourse(string course) => _courses.Add(course);
        public void RemoveCourse(string course) => _courses.Remove(course);
    }
}