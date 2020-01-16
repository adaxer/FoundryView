using System.Windows;
using FoundryView.Client.Wpf.Modules.InstallationsModule;
using FoundryView.Client.Wpf.Modules.NorthwindModule;
using FoundryView.Client.Wpf.Shell.Services;
using FoundryView.Client.Wpf.Shell.ViewModels;
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
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ISettingsService, WpfSettingsService>();
        }

        protected override Window CreateShell()
        {
            return new Views.MainWindow();
        }

        protected override void InitializeShell(Window shell)
        {
            base.InitializeShell(shell);
            shell.DataContext = Container.Resolve<MainViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<NorthwindInitializer>();
            moduleCatalog.AddModule<InstallationsInitializer>();
        }
    }
}
