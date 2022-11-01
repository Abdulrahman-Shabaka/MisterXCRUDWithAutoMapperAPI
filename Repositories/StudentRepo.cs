using System;
using MisterX.Interfaces;
using MisterX.Models;

namespace MisterX.Repositories
{
    public class StudentRepo:IStudent
    {
        private readonly MisterXDbContext _db;
        public StudentRepo(MisterXDbContext db)
        {
            _db = db;
        }

        public Student Create(Student Model)
        {
            _db.Students.Add(Model);
            _db.SaveChanges();
            return Model;
        }

        public bool Delete(int Id)
        {
            try
            {
                Student student = FindById(Id);
                _db.Students.Remove(student);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public Student FindById(int Id) => _db.Students.Find(Id);

        public List<Student> GetAll()=> _db.Students.ToList();

        public Student? Update(Student Model)
        {
            try
            {
                Student student = FindById(Model.Id);

                student.Adress = Model.Adress;
                student.Age = Model.Age;
                student.Fname = Model.Fname;
                student.Lname = Model.Lname;
                student.Room_Id = Model.Room_Id;
                student.Gender = Model.Gender;
                student.Level = Model.Level;

                _db.SaveChanges();

                return Model;
            }
            catch
            {
                return null;
            }
       
        }
    }
}

