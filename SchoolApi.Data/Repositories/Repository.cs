using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Data.Interfaces;
using SchoolApi.Domain.Entities;

namespace SchoolApi.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async ValueTask<T> AddAsync(T entity)
        {
            try
            {
                entity.DateCreated = DateTime.Now;
                await _context.Set<T>().AddAsync(entity);
            }
            catch (Exception e)
            {
                throw e;
            }

            return entity;
        }

        public async Task<bool> ExistAsync(Guid id)
        {
            return await _context.Set<T>().AnyAsync(x => x.Id == id);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>()
                .Where(predicate)
                .AsQueryable();
        }

        public async ValueTask<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async ValueTask<T> GetByIdAsync(Guid id)
        {
            try
            {
                return await _context.Set<T>()
                    .FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            try
            {
                var entity = await _context.Set<T>().SingleOrDefaultAsync(x => x.Id == id);
                if(entity == null)
                    return false;

                var result = _context.Set<T>().Remove(entity);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async ValueTask<T> UpdateAsync(T entity)
        {
            try
            {
                var result = await _context.Set<T>().SingleOrDefaultAsync(x => x.Id == entity.Id);
                if(result == null)
                    return null;

                entity.DateUpdated = DateTime.UtcNow;
                entity.DateCreated = result.DateCreated;
                
                _context.Entry(result).State = EntityState.Detached;
                _context.Entry(entity).State = EntityState.Modified;
            }
            catch (System.Exception e)
            {
                throw e;
            }

            return entity;
        }
    }
}