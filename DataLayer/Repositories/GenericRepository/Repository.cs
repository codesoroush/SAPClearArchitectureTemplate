using DataLayer.Context;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataLayer.Repositories.GenericRepository
{

    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly DbSet<T> _dbSet;
        private readonly ApplicationDbContext _context;


        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            return result.Entity;
        }


        public void AddRange(List<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
    
            return await _dbSet.ToListAsync();
        }


        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<T> GetById(string id)
        {
            return await _dbSet.FindAsync(id);
        }
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

    }
}
