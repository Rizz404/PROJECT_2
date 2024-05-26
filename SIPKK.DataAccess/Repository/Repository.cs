using Microsoft.EntityFrameworkCore;
using SIPKK.DataAccess.Data;
using SIPKK.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository
{
    //nanti kalo implement interface tinggal hover terus alt enter lalu implement
    //classnya juga harus generic kalau reponya pakai generic
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(AplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            return await query.Where(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IQueryable<T> query = dbSet;
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
