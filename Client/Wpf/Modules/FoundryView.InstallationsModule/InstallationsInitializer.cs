using System;
using System.Collections.Generic;
using System.Text;
using FoundryView.Client.Wpf.Modules.InstallationsModule.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using WpfCommonLib.Interfaces;

namespace FoundryView.Client.Wpf.Modules.InstallationsModule
{
    public class InstallationsInitializer : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IPlugin, InstallationsPluginViewModel>(nameof(InstallationsPluginViewModel));
        }
    }
}
