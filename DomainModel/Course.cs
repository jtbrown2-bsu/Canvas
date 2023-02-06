using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Course
    {
        public int Id { get; set; }
        public DateTime Semester { get; set; }
        public string Name { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Module> Modules { get; set; }
        public List<Student> Students { get; set; }
        public Instructor Instructor { get; set; }

        public void addAnnouncement(Announcement announcement)
        {
            Announcements.Add(announcement);
        }

        public void addStudent(Student student)
        {
            Students.Add(student);
        }

        public void addModule(Module module)
        {
            Modules.Add(module);
        }
    }
}
