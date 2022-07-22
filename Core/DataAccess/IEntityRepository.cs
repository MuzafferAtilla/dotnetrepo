using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<ICollection<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task<T> GetById(Expression<Func<T, bool>> filter);
    }
}
