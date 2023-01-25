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

        SearchTable searchTable = null;
        Button button = null;

        private async void searchBtn_Clicked(object sender, EventArgs e)
        {
            button = sender as Button;
            switch (button.Text)
            {
                case "Поиск":
                    searchTable = new SearchTable();
                    await Navigation.PushAsync(searchTable);

                    break;
                case "Сброс":
                    abonentList.ItemsSource = App.abonents;
                    button.Text = "Поиск";
                    break;

            }


        }
        private void Search()
        {

        }

        protected override void OnAppearing()
        {
            if (searchTable != null)
            {
                var x = abonentList.ItemsSource = App.abonents.Where(n => n.Address == searchTable.SearchingAddress).ToList();
                if (x != null) abonentList.ItemsSource = x;
                else DisplayAlert("Ошибка", "Нет подходящих записей", "OK");
                button.Text = "Сброс";
                searchTable = null;
            }
            base.OnAppearing();
        }
    }


}
