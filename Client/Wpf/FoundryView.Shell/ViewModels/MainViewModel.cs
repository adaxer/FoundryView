using System;
using FoundryView.Client.Wpf.Shell.Services;
using Prism;
using Prism.Events;
using WpfCommonLib.Events;
using WpfCommonLib.ViewModels;

namespace FoundryView.Client.Wpf.Shell.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ISettingsService _settingsService;
        private readonly IEventAggregator _eventAggregator;

        public UISettings UISettings { get; }

        public NavigatorViewModel Navigator { get; set; }
        public StatusBarViewModel StatusBar { get; set; }
        public ViewModelBase ActiveElement { get; set; }

        public MainViewModel(ISettingsService settingsService, StatusBarViewModel statusBar, NavigatorViewModel navigator, IEventAggregator eventAggregator)
        {
            StatusBar = statusBar;
            Navigator = navigator;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<ChangeModuleEvent>().Subscribe(ChangeModule);
            _settingsService = settingsService;
            UISettings = _settingsService.Settings;
            Title = "FoundryView - Application";
        }

        private void ChangeModule(ViewModelBase newElement)
        {
            if (ActiveElement != null && ActiveElement.IsBusy)
            {
                // todo: Add Dialog for Navigating away
                // return;
            };
            ActiveElement = newElement;
        }
    }
}
