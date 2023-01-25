using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pr12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        private Abonent CurrentAbonent { get; set; }
        public InfoPage()
        {
            InitializeComponent();
            dltBtn.IsEnabled = false;
            dltBtn.IsVisible = false;
            cngBtn.IsEnabled = false;
            cngBtn.IsVisible = false;
        }
        public InfoPage(Abonent abonent)
        {
            InitializeComponent();
            CurrentAbonent = abonent;
            addBtn.IsEnabled = false;
            addBtn.IsVisible = false;
            nameEntry.Text = abonent.Name;
            phoneEntry.Text = abonent.Phone;
            addressEntry.Text = abonent.Address;
        }

        private void addBtn_Clicked(object sender, EventArgs e)
        {
            App.abonents.Add(new Abonent { Address = addressEntry.Text, Name = nameEntry.Text, Phone = phoneEntry.Text });
            Navigation.PopAsync();
        }

        private void dltBtn_Clicked(object sender, EventArgs e)
        {
            App.abonents.Remove(CurrentAbonent);
            Navigation.PopAsync();
        }

        private void cngBtn_Clicked(object sender, EventArgs e)
        {
            var a = App.abonents.IndexOf(CurrentAbonent);
            CurrentAbonent.Name = nameEntry.Text;
            CurrentAbonent.Address = addressEntry.Text;
            CurrentAbonent.Phone = phoneEntry.Text;
                //MainPage.abonents[a].Phone = phoneEntry.Text;
            Navigation.PopAsync();
        }
    }
}