using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Student : Person
    {
        public List<Course> CoursesEnrolled { get; set; }
        public void addCourse(Course course)
        {
            CoursesEnrolled.Add(course);
        }
    }
}
