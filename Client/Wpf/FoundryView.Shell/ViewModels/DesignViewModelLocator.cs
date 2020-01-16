using System;
using System.Collections.Generic;
using System.Text;
using FoundryView.Client.Wpf.Shell.Services;
using WpfCommonLib.Interfaces;

namespace FoundryView.Client.Wpf.Shell.ViewModels
{
    public class DesignViewModelLocator
    {
        public MainViewModel Main => new MainViewModel(null, new StatusBarViewModel(), new NavigatorViewModel(null), null);

        public StatusBarViewModel StatusBar => new StatusBarViewModel {Message = "Designtime-Statusbar"};
    }
}
