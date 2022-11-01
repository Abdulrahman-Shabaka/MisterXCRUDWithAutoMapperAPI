using System;
namespace MisterX.Interfaces
{
    public interface IBase<T>
    {
        public List<T> GetAll();
        public T FindById(int Id);
        public T Update(T Model);
        public bool Delete(int Id);
        public T Create(T Model);
    }
}

