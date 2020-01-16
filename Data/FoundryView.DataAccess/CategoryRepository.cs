using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoundryView.Data.DataAccess.Models;
using FoundryView.UseCases.Contracts.Interfaces;
using FoundryView.UseCases.Contracts.Models;

namespace FoundryView.Data.DataAccess
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly IPersistenceProvider<Categories> _persistenceProvider;
        private readonly IMapper _mapper;

        public CategoryRepository(IPersistenceProvider<Categories> persistenceProvider, IMapper mapper)
        {
            this._persistenceProvider = persistenceProvider;
            this._mapper = mapper;
        }
        public Task<Category> AddOrUpdate(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> FindAll()
        {
            var cats = await _persistenceProvider.Find();
            var result = _mapper.Map<IEnumerable<Categories>,IEnumerable<Category>>(cats);
            return result;
        }

        public async Task<Category> FindById(int id)
        {
            var cat = (await _persistenceProvider.Find(c=>c.CategoryId == id)).SingleOrDefault();
            return cat == null ? null : _mapper.Map<Categories, Category>(cat);
        }
    }
}
