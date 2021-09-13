using Domain.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class BaseRepository : IRepository
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context; 
        }

        public async Task<T> Create<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll<T>() where T : class
        {
            var result = await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetById<T>(int id) where T : class
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<bool> Remove<T>(int id) where T : class
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(entity);
            var result = await _context.SaveChangesAsync();
            
            return (result != 0);
        } 

        public async Task<bool> Update<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
            var result = await _context.SaveChangesAsync();

            return (result != 0);
        }
    }
}
