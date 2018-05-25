using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace WifiPhotonHouse
{
    public class CoreInfo
    {
        [JsonProperty("last_app")]
        public string Last_app { get; set; }
        [JsonProperty("last_heard")]
        public DateTime Last_heard { get; set; }
        [JsonProperty("connected")]
        public bool Connected { get; set; }
        [JsonProperty("last_handshake_at")]
        public DateTime Last_handshake_at { get; set; }
        [JsonProperty("deviceID")]
        public string DeviceID { get; set; }
        [JsonProperty("product_id")]
        public int Product_id { get; set; }
    }

    public class RootObject
    {
        [JsonProperty("cmd")]
        public string Cmd { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("result")]
        public double Result { get; set; }
        [JsonProperty("coreInfo")]
        public CoreInfo CoreInfo { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        private const string Url = "https://api.particle.io/v1/devices/4b0047000751353530373132/temp?access_token=0f4384bd65ba35fac75ae7ea740214655b485ea4";

        private HttpClient PhotonHttpClient = new HttpClient();

        private async void GetTemperature()
        {
            var response = await PhotonHttpClient.GetAsync(Url);
            var responseContent = await response.Content.ReadAsStringAsync();
            var photonValues = JsonConvert.DeserializeObject<RootObject>(responseContent);
            var temp = Math.Round(photonValues.Result);
            Temp_label.Text = String.Format("{0}°C", temp.ToString());
            //Temp_label.Text = String.Format("{0:F1}°C", temp);
        }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ShowTemperatureAsync();
        }

        private async void Focos_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FocosPage(), false);
        }


        private async void Temp_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VentiladorPage(), false);
        }

        private async void Time_Button(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BombaPage(), false);
        }


        private async Task ShowTemperatureAsync()
        {
            while (true)
            {
                await Task.Delay(2000);
                GetTemperature();
            }
        }
    }
}
