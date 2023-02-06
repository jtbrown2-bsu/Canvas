using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<byte[]> Attachments { get; set; }
        public Instructor Instructor { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public void addFile(byte[] file)
        {
            Attachments.Add(file);
        }
    }
}
