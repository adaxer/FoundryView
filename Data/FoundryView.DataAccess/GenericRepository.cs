using FoundryView.UseCases.Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FoundryView.Data.DataAccess
{
    public class GenericRepository<T> : IRepository<T> where T:class
    {
        readonly NorthwindContext _context;

        public GenericRepository(NorthwindContext uow)
        {
            _context = uow;// as ISouthwindDb;
        }

        public virtual async Task<T> AddOrUpdate(T entity, Func<T, T, bool>compare)
        {
            var inDb = await _context.Set<T>().SingleOrDefaultAsync(m => compare(m,entity)==true);
            if (inDb == null)
            {
                _context.Set<T>().Add(entity);
            }
            else
            {
                _context.Entry<T>(inDb).State = EntityState.Detached;
                _context.Set<T>().Update(entity);
            }
            await Save();
            return entity;
        }

        public virtual Task<bool> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return Task.FromResult(true);
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return await _context.Set<T>().ToListAsync();
            }
            else
            {
                return await _context.Set<T>().Where(filter).ToListAsync();
            }
        }

        public virtual async Task<bool> Save()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
