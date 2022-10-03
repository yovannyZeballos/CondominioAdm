using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Condominio.Adm.Dominio.Repositorios
{
    public interface IReadRepository<T> where T : class
    {
        Task<T> SingleAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? take = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<T> SingleOrDefaultAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
        int Count(Expression<Func<T, bool>> predicate = null);
        Task<decimal?> SumAsync(Expression<Func<T, bool>> predicate = null);
        decimal? Sum(Expression<Func<T, bool>> predicate = null);
        Task<int> MaxAsync(Expression<Func<T, int>> selector = null, Expression<Func<T, bool>> predicate = null);
    }
}
