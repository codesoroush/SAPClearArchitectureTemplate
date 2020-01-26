using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.GenericRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetById(int id);
        Task<T> GetById(string id);
        Task<IEnumerable<T>> GetAll();
        void AddRange(List<T> entities);
    }
}
