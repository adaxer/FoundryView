using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WpfCommonLib.Events;
using WpfCommonLib.Interfaces;
using WpfCommonLib.ViewModels;

namespace FoundryView.Client.Wpf.Modules.NorthwindModule.ViewModels
{
    public class NorthwindPluginViewModel : PluginViewModel
    {
        public NorthwindPluginViewModel(NorthwindViewModel northwind, IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Stammdaten";
            ViewModel = northwind;
        }
        public sealed override ViewModelBase ViewModel { get; protected set; }
    }
}
