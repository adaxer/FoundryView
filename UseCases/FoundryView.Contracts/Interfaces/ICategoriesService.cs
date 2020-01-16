using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FoundryView.UseCases.Contracts.Models;

namespace FoundryView.UseCases.Contracts.Interfaces
{
    public interface ICategoriesService
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
