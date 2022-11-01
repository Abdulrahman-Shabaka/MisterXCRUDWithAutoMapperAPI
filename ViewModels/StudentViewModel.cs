using System;
using MisterX.Models;

namespace MisterX.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public Gender Gender { get; set; }
        public Level Level { get; set; }

        public int Room_Id { get; set; }
    }
}

