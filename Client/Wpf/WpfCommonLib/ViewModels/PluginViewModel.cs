using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using WpfCommonLib.Events;
using WpfCommonLib.Interfaces;

namespace WpfCommonLib.ViewModels
{
    public abstract class PluginViewModel : ViewModelBase, IPlugin
    {
        private readonly IEventAggregator _eventAggregator;

        protected PluginViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public abstract ViewModelBase ViewModel {get; protected set; }
       
        public ICommand ActivateCommand => new DelegateCommand(Activate, CanActivate);

        protected virtual bool CanActivate() => true;

        protected virtual void Activate()
        {
            _eventAggregator.GetEvent<ChangeModuleEvent>().Publish(ViewModel);
        }
    }

}
