using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SchoolApi.Domain.Entities;

namespace SchoolApi.Data.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        ValueTask<T> GetByIdAsync(Guid id);
        ValueTask<IEnumerable<T>> GetAllAsync();

        Task<bool> ExistAsync(Guid id);

        ValueTask<T> AddAsync(T entity);
        ValueTask<T> UpdateAsync(T entity);

        Task<bool> RemoveAsync(Guid id);
    }
}