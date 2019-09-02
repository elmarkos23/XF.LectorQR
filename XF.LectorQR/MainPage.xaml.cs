using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;


namespace XF.LectorQR
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void BtnScan_Clicked(object sender, EventArgs e)
		{
			var scan = new ZXing.Net.Mobile.Forms.ZXingScannerPage();
			scan.Title = "Escaner código de barras";
			await Navigation.PushAsync(scan);
			scan.OnScanResult += (result) =>
			{
				Device.BeginInvokeOnMainThread(async () =>
				{
					await Navigation.PopAsync();
					lblCode.Text = result.Text;
					
				});
			};
		}
	}
}
