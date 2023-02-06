using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Instructor : Person
    {
        public List<Course> CoursesTaught { get; set; }
        public void addCourseTaught(Course course)
        {
            CoursesTaught.Add(course);
        }
    }
}
