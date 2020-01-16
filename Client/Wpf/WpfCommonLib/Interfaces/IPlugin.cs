using System;
using System.Collections.Generic;
using System.Text;
using WpfCommonLib.ViewModels;

namespace WpfCommonLib.Interfaces
{
    public interface IPlugin
    {
        string Title { get; }
        ViewModelBase ViewModel { get; }
    }
}
