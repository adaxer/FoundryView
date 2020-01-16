using System;
using System.Collections.Generic;
using System.Text;
using FoundryView.UseCases.Contracts.Interfaces;
using Prism.Ioc;
using Prism.Modularity;

namespace FoundryView.UseCases.Logic
{
    public class LogicInitializer : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICategoriesService, CategoriesService>();
        }
    }
}
