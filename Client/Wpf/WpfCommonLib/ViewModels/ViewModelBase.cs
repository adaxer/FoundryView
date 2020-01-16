using Prism.Mvvm;

namespace WpfCommonLib.ViewModels
{
    public class ViewModelBase : BindableBase
    {
        public ViewModelBase()
        {
            Title = GetType().Name;
        }

        public string Title { get; set; }

        public bool IsDirty { get; set; }
        public bool IsBusy { get; set; }
     }
}