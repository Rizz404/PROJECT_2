using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.DataAccess.Repository.IRepository
{
    // jangan lupa buat ini jadi public bukan internal
    public interface IRepository<T> where T : class
    {
        // sebenernya kurang tau ini type apaan tapi berasa keren aja jadi dipake
        Task<T> GetAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includedProperties);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includedProperties);

        Task<T> FindAsync(
           Expression<Func<T, bool>>? filter = null,
           Func<IQueryable<T>, IQueryable<T>>? include = null);

        Task<IEnumerable<T>> FindAllAsync(
            Expression<Func<T, bool>>? filter = null,
            int? skip = null,
            int? take = null,
            Func<IQueryable<T>, IQueryable<T>>? include = null);

        Task CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IEnumerable<T> entities);
    }
}
