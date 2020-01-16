using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoundryView.Client.Wpf.Shell.ViewModels
{
    public class StatusBarViewModel : ViewModelBase
    {
        public StatusBarViewModel()
        {
            StartTimer();
        }

        private void StartTimer()
        {
            Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    ApplicationTime = System.DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                    await Task.Delay(1000);
                }
            });
        }

        public string Message { get; set; }
        public string ApplicationTime { get; set; }
    }
}
