using FoundryView.UseCases.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using FoundryView.UseCases.Contracts.Models;
using WpfCommonLib.ViewModels;
using System.Windows.Input;
using Prism.Commands;

namespace FoundryView.Client.Wpf.Modules.NorthwindModule.ViewModels
{
    public class NorthwindViewModel : ViewModelBase
    {
        private readonly ICategoriesService _categoriesService;

        public NorthwindViewModel(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
            Title = "Willkommen bei Northwind";
        }

        public ICommand LoadCategoriesCommand => new DelegateCommand(LoadCategories);

        private async void LoadCategories()
        {
            Categories = await  _categoriesService.GetCategories();
        }

        public string QualitiesTitle { get; set; } = "Unsere Werkstoffe";

        public IEnumerable<Category> Categories { get; set; }
        public string MaterialsTitle { get; set; } = "Unsere Einsatz-Materialien";
        public string  ElementsTitle { get; set; } = "Betrachtete Elemente";
    }
}
