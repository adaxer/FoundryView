using System.IO;
using System.Windows;
using FoundryView.Client.Wpf.Modules.InstallationsModule;
using FoundryView.Client.Wpf.Modules.NorthwindModule;
using FoundryView.Client.Wpf.Shell.Services;
using FoundryView.Client.Wpf.Shell.ViewModels;
using FoundryView.Client.Wpf.Shell.Views;
using FoundryView.Data.DataAccess;
using FoundryView.Services.CommonServiceLib;
using FoundryView.UseCases.Contracts.Interfaces;
using FoundryView.UseCases.Logic;
using Microsoft.Extensions.Configuration;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace FoundryView.Client.Wpf.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        private MainWindow _shell;
        private IConfigurationRoot _configuration;
        private bool _isOnline;

        public App()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            _isOnline = _configuration.GetValue<bool>("UseRestApi");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ISettingsService, WpfSettingsService>();
            if (_isOnline)
            {
                containerRegistry.Register<ICategoriesService, RestCategoriesService>();
                containerRegistry.RegisterInstance<IRestService>(new RestService(_configuration.GetValue<string>("ServiceUrl")));
            }
        }

        protected override Window CreateShell()
        {
            _shell = new Views.MainWindow();
            return _shell;
        }

        protected override void InitializeShell(Window shell)
        {
            base.InitializeShell(shell);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            _shell.DataContext = Container.Resolve<MainViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<NorthwindInitializer>();
            moduleCatalog.AddModule<InstallationsInitializer>();
            if (!_isOnline)
            {
                moduleCatalog.AddModule<LogicInitializer>();
                moduleCatalog.AddModule<DataAccessInitializer>();
            }
        }
    }
}
