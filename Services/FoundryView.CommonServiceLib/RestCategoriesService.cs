using FoundryView.UseCases.Contracts.Interfaces;
using FoundryView.UseCases.Contracts.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FoundryView.Services.CommonServiceLib
{
    public class RestCategoriesService : ICategoriesService
    {
        private readonly IRestService _restService;

        public RestCategoriesService(IRestService restService)
        {
            this._restService = restService;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var result = await _restService.GetDataAsync<IEnumerable<Category>>("categories/all");
            return result;
        }
    }
}
