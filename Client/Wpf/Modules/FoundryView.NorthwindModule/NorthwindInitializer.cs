using System;
using System.Net.Mime;
using System.Windows;
using FoundryView.Client.Wpf.Modules.NorthwindModule.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using WpfCommonLib.Interfaces;

namespace FoundryView.Client.Wpf.Modules.NorthwindModule
{
    public class NorthwindInitializer : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            ResourceDictionary rd = new ResourceDictionary {Source = new Uri("pack://application:,,,/FoundryView.Client.Wpf.Modules.NorthwindModule;component/NorthwindResources.xaml", UriKind.Absolute)};
            Application.Current.Resources.MergedDictionaries.Add(rd);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IPlugin, NorthwindPluginViewModel>(nameof(NorthwindPluginViewModel));
        }
    }
}
