
using System.Collections.Generic;
using FoundryView.UseCases.Contracts.Interfaces;
using System.Threading.Tasks;
using FoundryView.UseCases.Contracts.Models;

namespace FoundryView.UseCases.Logic
{
    public class CategoriesService : ICategoriesService
    {
        public Task<IEnumerable<Category>> GetCategories()
        {
            return Task.FromResult(new List<Category>
            {
                new Category {Id = 1, Name = "IFM9", Description = "18MW Melting Furnace"},
                new Category {Id = 2, Name = "FS6", Description = "6MW Smart Melting Furnace"}
            } as IEnumerable<Category>);
        }
    }
}
