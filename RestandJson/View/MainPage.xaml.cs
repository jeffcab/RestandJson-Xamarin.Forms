using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RestandJson
{
	public partial class MainPage : ContentPage
	{
		MainPageViewModel vm;

		public MainPage ()
		{
			vm = new MainPageViewModel ();
			BindingContext = vm;
			InitializeComponent ();
		}

		public async void OnClicked(object o, EventArgs e){
			var longitude = double.Parse (Lon.Text);
			var latitude = double.Parse (Lat.Text);
			var url = string.Format ("http://api.geonames.org/findNearByWeatherJSON?lat={0}&lng={1}&username=jstylizzimo", latitude, longitude);
			await vm.GetWeatherAsync (url);
		}

	}
}

