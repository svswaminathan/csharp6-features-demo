using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp6_features_demo
{
    class IndexInitializer
    {
        public void Test()
        {
            var enrollment = new Enrollment()
            {
                new Student { FirstName ="Swami", LastName="Vetri"},
                new Student { FirstName= "John", LastName ="Doe"}
            };

            foreach (var item in enrollment)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");
            }
        }
    }

    class Enrollment : IEnumerable<Student>
    {

        List<Student> students = new List<Student>();

        public void Enroll(Student s)
        {
            students.Add(s);
        }
        public IEnumerator<Student> GetEnumerator()
        {
            return ((IEnumerable<Student>)students).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Student>)students).GetEnumerator();
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    static class StudentExtensions
    {
        public static void Add(this Enrollment e, Student s) => e.Enroll(s);
    }
}
