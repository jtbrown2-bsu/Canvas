using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<byte[]> Files { get; set; }
        public DateTime TimeToOpen { get; set; }
        public List<Assignment> Assignments { get; set; }
        public void addAssignment(Assignment assignment)
        {
            Assignments.Add(assignment);
        }
        public void addFile(byte[] file)
        {
            Files.Add(file);
        }
    }
}
