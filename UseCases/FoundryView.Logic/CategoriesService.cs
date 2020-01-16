
using System.Collections.Generic;
using FoundryView.UseCases.Contracts.Interfaces;
using System.Threading.Tasks;
using FoundryView.UseCases.Contracts.Models;

namespace FoundryView.UseCases.Logic
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoriesService(IRepository<Category> categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public Task<IEnumerable<Category>> GetCategories()
        {
            return _categoryRepository.FindAll();
        }
    }
}
