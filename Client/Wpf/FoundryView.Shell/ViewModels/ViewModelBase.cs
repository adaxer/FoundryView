using Prism.Mvvm;

namespace FoundryView.Client.Wpf.Shell.ViewModels
{
    public class ViewModelBase : BindableBase
    {
        public ViewModelBase()
        {
            Title = GetType().Name;
        }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}