using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace WifiPhotonHouse
{
    public partial class VentiladorPage : ContentPage
    {
        private const string Url = "https://api.particle.io/v1/devices/4b0047000751353530373132/ftmp";

        private HttpClient PhotonHttpClient = new HttpClient();

        private async Task FanWriteMemory(string parameter)
        {
            var body = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("access_token", "0f4384bd65ba35fac75ae7ea740214655b485ea4"),
                new KeyValuePair<string, string>("args", parameter),

            };
            var content = new FormUrlEncodedContent(body);
            await PhotonHttpClient.PostAsync(Url, content);
        }


        public VentiladorPage()
        {
            InitializeComponent();

            var app = Application.Current as App;
            Fan_slider.Value = app.FanSliderValue;
        }

        protected override void OnDisappearing()
        {
            Application.Current.SavePropertiesAsync();
            base.OnDisappearing();
        }

        private async void AcceptButton_OnClicked(object sender, EventArgs e)
        {
            var app = Application.Current as App;
            app.FanSliderValue = Fan_slider.Value;
            int fanValue = (int)Math.Round(Fan_slider.Value);
            await FanWriteMemory(fanValue.ToString());
            await DisplayAlert("Temperatura establecida:", fanValue.ToString()+"ºC", "OK");

        }
    }
}
