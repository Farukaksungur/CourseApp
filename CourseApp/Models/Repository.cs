using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<Student> _student = new List<Student>();

        public static List<Student> Students
        {
            get
            {
                return _student;
            }
            
        }
        public static void AddStudent(Student student)
        {
            _student.Add(student);
        }
    }
}
