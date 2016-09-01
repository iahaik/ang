
using System.Collections.Generic;

namespace ang.Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
