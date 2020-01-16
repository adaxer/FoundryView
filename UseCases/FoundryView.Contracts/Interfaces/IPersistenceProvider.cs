using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FoundryView.UseCases.Contracts.Interfaces
{
    public interface IPersistenceProvider<T> where T : class
    {
        Task<T> AddOrUpdate(T entity, Func<T, T, bool> compare);

        Task<bool> Delete(T entity);

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> filter=null);

        Task<bool> Save();
    }

}
