using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository
{
    //nanti kalo implement interface tinggal hover terus alt enter lalu implement
    //classnya juga harus generic kalau reponya pakai generic
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includedProperties)
        {
            IQueryable<T> query = dbSet;

            if(filter != null)
            {
                query = query.Where(filter);
            }

            if(includedProperties != null && includedProperties.Any())
            {
                query = includedProperties.Aggregate(query, (current, includedProp) => current.Include(includedProp));
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includedProperties)
        {
            IQueryable<T> query = dbSet;

            if(filter != null)
            {
                query = query.Where(filter);
            }

            if(includedProperties != null && includedProperties.Any())
            {
                query = includedProperties.Aggregate(query, (current, includedProp) => current.Include(includedProp));
            }

            return await query.ToListAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => dbSet.Remove(entity));
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            await Task.Run(() => dbSet.RemoveRange(entities));
        }
    }
}
