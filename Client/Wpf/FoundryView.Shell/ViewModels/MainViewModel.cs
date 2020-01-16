using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using FoundryView.Client.Wpf.Shell.Services;

namespace FoundryView.Client.Wpf.Shell.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ISettingsService _settingsService;

        public UISettings UISettings { get; }

        public NavigatorViewModel Navigator { get; set; }
        public StatusBarViewModel StatusBar { get; set; }
        public ViewModelBase ActiveElement { get; set; }

        public MainViewModel(ISettingsService settingsService, StatusBarViewModel statusBar, NavigatorViewModel navigator)
        {
            StatusBar = statusBar;
            Navigator = navigator;
            _settingsService = settingsService;
            UISettings = _settingsService.Settings;
            Title = "FoundryView - Application";
        }
    }
}
