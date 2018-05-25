using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace WifiPhotonHouse
{
    public partial class BombaPage : ContentPage
    {
        private const string Url = "https://api.particle.io/v1/devices/4b0047000751353530373132/btime";

        private HttpClient PhotonHttpClient = new HttpClient();

        private async Task BombTimeWrite(string parameter)
        {
            var body = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("access_token", "0f4384bd65ba35fac75ae7ea740214655b485ea4"),
                new KeyValuePair<string, string>("args", parameter),

            };
            var content = new FormUrlEncodedContent(body);
            await PhotonHttpClient.PostAsync(Url, content);
        }

        public BombaPage()
        {
            InitializeComponent();
        }

        private async void AcceptButton_Clicked(object sender, System.EventArgs e)
        {
            await BombTimeWrite(timeEntry.Text);
            await DisplayAlert("Tiempo establecido:", timeEntry.Text + " min", "OK");
        }
    }
}
