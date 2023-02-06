using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Grade
    {
        public int Id { get; set; }
        public float Percentage { get; set; }
        public Instructor Instructor { get; set; }
        public Student Student { get; set; }
        public Assignment Assignment { get; set; }
    }
}
