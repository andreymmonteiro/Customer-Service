using Customer.Data.Context;
using Customer.Domain.Entities;
using Customer.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private readonly DbSet<T> _db;
        private const int ZERO = 0;

        public BaseRepository(MyContext context)
        {
            _db = context.Set<T>();
            _context = context;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _db.SingleAsync<T>(single => single.Id.Equals(id));
            var result = _context.Remove(entity);
            return await _context.SaveChangesAsync() > ZERO;

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.ToListAsync();
        }

        public async Task<T> InsertAsync(T entity)
        {
            _db.Add(entity);
            if(await _context.SaveChangesAsync() > ZERO)
            {
                return entity;
            }
            return null;
        }

        public async Task<T> SingleAsync(Guid id)
        {
            return await _db.AsNoTracking().SingleAsync(single => single.Id.Equals(id));            
        }

        public async Task<T> UpdateAsync(T entity)
        {
            entity.UpdateAt = DateTime.Now;
            _db.Update(entity);
            if(await _context.SaveChangesAsync() > ZERO)
            {
                return entity;
            }
            return null;
        }
    }
}
