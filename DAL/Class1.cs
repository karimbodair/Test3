using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IRepositories<T>
    {
        void Create(T entity);
        void Delete (int index);
        void Update(string index, string entity);
        List<T> GetAll();
    }
}
