using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pr12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            abonentList.ItemsSource = App.abonents;
        }

        private async void Add_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        private async void TappedItem(object sender, ItemTappedEventArgs e)
        {
            var temp = (Abonent)abonentList.SelectedItem;
            await Navigation.PushAsync(new InfoPage(temp));
        }
    }
}
