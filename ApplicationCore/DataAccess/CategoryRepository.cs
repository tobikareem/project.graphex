using Application.Interfaces;
using Application.Enitities;
using System.Collections.Generic;

namespace Infrastructure.DataAccess
{
    public class CategoryRepository : IRepository<Category>
    {
        public CategoryRepository()
        {
        }

        public void Add(Category obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
