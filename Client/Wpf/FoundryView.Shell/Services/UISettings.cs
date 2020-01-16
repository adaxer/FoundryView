using Prism.Mvvm;

namespace FoundryView.Client.Wpf.Shell.Services
{
    public class UISettings : BindableBase
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public bool IsMaximized { get; set; }
    }
}
