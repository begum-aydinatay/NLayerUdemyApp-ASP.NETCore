using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class 
    {
        // x -> f(x) being isIdBiggerY(x) -> true/false
        // when IQueryable is used, you can do prodRepo.where(x->x.id>5).OrderBy.ToListAsync()
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll();

        Task<T> GetByIdAsync(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity); //  change the state of the entity
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
