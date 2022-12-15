using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.BusinessLayer.Repository.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        /*İstemciden gelecek olan işlemlerin yapılacağı alan olarak belirliyoruz.*/
        Task<T> GetAsync(Expression<Func<T, bool>> pred, params Expression<Func<T, object>>[] includeRepo);
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> pred = null, params Expression<Func<T, object>>[] includeRepo);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> pred);
        Task<int> CountAsync(Expression<Func<T, bool>> pred);
    }
}
