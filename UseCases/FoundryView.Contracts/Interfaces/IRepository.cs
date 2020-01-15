using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FoundryView.UseCases.Contracts.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddOrUpdate(T entity);

        Task<bool> Delete(T entity);

        Task<IQueryable<T>> Find(Expression<Func<T, bool>> filter=null);

        Task<bool> Save();
    }

}
