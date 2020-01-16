using System;
using System.Collections.Generic;

namespace FoundryView.UseCases.Contracts.Models
{
    public class Category : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
