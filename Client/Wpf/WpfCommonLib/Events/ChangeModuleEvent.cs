using System;
using System.Collections.Generic;
using System.Text;
using Prism.Events;
using WpfCommonLib.ViewModels;

namespace WpfCommonLib.Events
{
    public class ChangeModuleEvent : PubSubEvent<ViewModelBase>
    {
    }
}
