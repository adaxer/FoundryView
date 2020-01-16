using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using WpfCommonLib.Events;
using WpfCommonLib.Interfaces;
using WpfCommonLib.ViewModels;

namespace FoundryView.Client.Wpf.Modules.InstallationsModule.ViewModels
{
    public class InstallationsPluginViewModel : PluginViewModel
    {

        public InstallationsPluginViewModel(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Installationen";
            ViewModel = new ViewModelBase { Title = "Installationen tbd" };
        }

        public sealed override ViewModelBase ViewModel { get; protected set; }

    }
}
