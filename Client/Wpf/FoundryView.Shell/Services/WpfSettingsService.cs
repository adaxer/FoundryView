using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Prism.Mvvm;

namespace FoundryView.Client.Wpf.Shell.Services
{
    public partial class WpfSettingsService : BindableBase, ISettingsService
    {
        public WpfSettingsService()
        {
            Load();
            Settings.PropertyChanged += (s, e) => Save();
        }

        private void Load()
        {
            try
            {
                if (File.Exists("UISettings.json"))
                {
                    Settings = JsonConvert.DeserializeObject<UISettings>(File.ReadAllText("UISettings.json"));
                }
                else
                {
                    Settings = CreateDefaultSettings();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Settings = CreateDefaultSettings();
            }
        }

        private static UISettings CreateDefaultSettings()
        {
            return new UISettings
            { Width = 1000, Height = 700 };
        }

        private void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Settings);
                File.WriteAllText("UISettings.json", json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public UISettings Settings { get; set; }
    }
}
