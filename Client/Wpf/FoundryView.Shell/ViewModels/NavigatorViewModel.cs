using System.Collections.Generic;
using System.Threading.Tasks;
using Unity;
using WpfCommonLib.Interfaces;
using WpfCommonLib.ViewModels;

namespace FoundryView.Client.Wpf.Shell.ViewModels
{
    public class NavigatorViewModel : ViewModelBase
    {
        public IEnumerable<IPlugin> Plugins { get; }

        public NavigatorViewModel(IEnumerable<IPlugin> plugins)
        {
            Plugins = plugins;
        }
    }
}
