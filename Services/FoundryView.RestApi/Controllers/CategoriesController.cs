using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoundryView.UseCases.Contracts.Interfaces;
using FoundryView.UseCases.Contracts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoundryView.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {

        private readonly ILogger<CategoriesController> _logger;
        private readonly ICategoriesService _categoriesService;

        public CategoriesController(ILogger<CategoriesController> logger, ICategoriesService categoriesService)
        {
            _logger = logger;
            _categoriesService = categoriesService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Category>> Get()
        {
            var result = await _categoriesService.GetCategories();
            return result;
        }
    }
}
