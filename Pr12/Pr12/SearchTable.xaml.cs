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
	public partial class SearchTable : ContentPage
	{
		public string SearchingAddress { get; set; } = string.Empty;
		public SearchTable ()
		{
			InitializeComponent ();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			SearchingAddress = addressEntry.Text;
			Navigation.PopAsync();
		}
    }
}