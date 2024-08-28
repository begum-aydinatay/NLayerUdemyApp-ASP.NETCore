using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        // x -> f(x) being isIdBiggerY(x) -> true/false
        // when IQueryable is used, you can do prodRepo.where(x->x.id>5).OrderBy.ToListAsync()
        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity); // Now Task is used because the results will be reflected to the database
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
