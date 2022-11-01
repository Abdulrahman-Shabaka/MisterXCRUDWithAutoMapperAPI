using System;
namespace MisterX.Models
{
    public class Room
    {
        public Room()
        {
            Students = new List<Student>();
        }
        public int  Id { get; set; }
        public string Name { get; set; }
        public virtual List<Student>? Students { get; set; }
    }
}

