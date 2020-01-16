using System.Windows;
using FoundryView.Client.Wpf.Modules.InstallationsModule;
using FoundryView.Client.Wpf.Modules.NorthwindModule;
using FoundryView.Client.Wpf.Shell.Services;
using FoundryView.Client.Wpf.Shell.ViewModels;
using FoundryView.Client.Wpf.Shell.Views;
using FoundryView.UseCases.Logic;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;

namespace FoundryView.Client.Wpf.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        private MainWindow _shell;

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ISettingsService, WpfSettingsService>();
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
            moduleCatalog.AddModule<LogicInitializer>();
        }
    }
}
