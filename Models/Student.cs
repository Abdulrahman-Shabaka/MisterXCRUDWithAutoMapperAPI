using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisterX.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public  string Lname { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public Gender Gender { get; set; }
        public Level Level { get; set; }

        [ForeignKey("Room")]
        public int Room_Id { get; set; }
        public virtual Room? Room { get; set; }
    }

    public enum Gender
    {
        Male=0,Female=1
    }

    public enum Level
    {
        Level1=1,Level2=2,Level3=3
    }
}

