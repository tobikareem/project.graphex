using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Update(int id);
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
