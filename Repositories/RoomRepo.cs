using System;
using MisterX.Interfaces;
using MisterX.Models;

namespace MisterX.Repositories
{
    public class RoomRepo:IRoom
    {
        MisterXDbContext _db;
        public RoomRepo(MisterXDbContext db)
        {
            _db = db;
        }

        public Room Create(Room Model)
        {
            _db.Rooms.Add(Model);
            _db.SaveChanges();
            return Model;
        }

        public bool Delete(int Id)
        {
            try
            {
                Room room = FindById(Id);
                _db.Rooms.Remove(room);
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public Room FindById(int Id) => _db.Rooms.Find(Id);

        public List<Room> GetAll() => _db.Rooms.ToList();

        public Room Update(Room Model)
        {
            try
            {
                Room room = FindById(Model.Id);

                room.Name = Model.Name;

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

