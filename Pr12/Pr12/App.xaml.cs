using System;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace Pr12
{
    public partial class App : Application
    {

        public static ObservableCollection<Abonent> abonents = new ObservableCollection<Abonent>();
        public App()
        {
            InitializeComponent();
            if (Application.Current.Properties.TryGetValue("db", out object value) == true)
            {
                var list = JsonConvert.DeserializeObject<List<Abonent>>(value.ToString());
                App.abonents = new ObservableCollection<Abonent>(list);
            }
            else
            {
                string json = JsonConvert.SerializeObject(abonents);
                Application.Current.Properties["db"] = json;
                Application.Current.SavePropertiesAsync();
            }

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            string json = JsonConvert.SerializeObject(abonents);     
            Application.Current.Properties["db"] = json;
            Application.Current.SavePropertiesAsync();
        }

        protected override void OnResume()
        {
        }

    }
}
