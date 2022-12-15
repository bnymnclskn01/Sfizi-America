using Microsoft.EntityFrameworkCore;
using SfiziAmerica.BusinessLayer.Repository.Abstract;
using SfiziAmerica.EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SfiziAmerica.BusinessLayer.Repository.Concrete
{
    public class EntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        public EntityRepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> pred)
        {
            return await _context.Set<TEntity>().AnyAsync(pred);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> pred)
        {
            return await _context.Set<TEntity>().CountAsync(pred);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => {
                _context.Set<TEntity>().Remove(entity);
            });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> pred = null, params Expression<Func<TEntity, object>>[] includeRepo)
        {
            IQueryable<TEntity> entities = _context.Set<TEntity>(); // query tekrar yazmamak için tanımlandı nesne tanımlaması yapar gibi
            if (pred != null) // koşullu listeleme yapmak için kullanılır.
            {
                entities = entities.Where(pred);
            }
            //Tablomuz Birden fazla ve veya Bir tane tabloyla ilişkiliylse işlemlerde o tabloya ihtiyaç varsa include metotuyla o tabloyla birlikte işlem yapabilmemizi sağlayan include query kodudur.
            if (includeRepo.Any())
            {
                foreach (var item in includeRepo)
                {
                    entities = entities.Include(item);
                }
            }
            return await entities.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> pred, params Expression<Func<TEntity, object>>[] includeRepo)
        {
            IQueryable<TEntity> entities = _context.Set<TEntity>();
            if (pred != null)
            {
                entities = entities.Where(pred);
            }

            foreach (var item in includeRepo)
            {
                entities = entities.Include(item);
            }
            return await entities.SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _context.Set<TEntity>().Update(entity);
            });
        }
    }
}
