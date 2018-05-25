using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace WifiPhotonHouse
{
    public partial class FocosPage : ContentPage
    {
        private const string Url = "https://api.particle.io/v1/devices/4b0047000751353530373132/dw";

        private HttpClient PhotonHttpClient = new HttpClient();

        private async void LightBulbState(string parameter)
        {
            var body = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("access_token", "0f4384bd65ba35fac75ae7ea740214655b485ea4"),
                new KeyValuePair<string, string>("args", parameter),

            };
            var content = new FormUrlEncodedContent(body);
            await PhotonHttpClient.PostAsync(Url, content);
        }

        public FocosPage()
        {
            InitializeComponent();

            var app = Application.Current as App;
            LightBulb1_switch.IsToggled = app.LightBulb1Toogled;
            LightBulb2_switch.IsToggled = app.LightBulb2Toogled;
            LightBulb3_switch.IsToggled = app.LightBulb3Toogled;
            LightBulb4_switch.IsToggled = app.LightBulb4Toogled;
            LightBulb5_switch.IsToggled = app.LightBulb5Toogled;
            LightBulb6_switch.IsToggled = app.LightBulb6Toogled;
            LightBulb7_switch.IsToggled = app.LightBulb7Toogled;
        }

        private void LightBulb1_OnToggled(object sender, ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.LightBulb1Toogled = LightBulb1_switch.IsToggled;

            if (e.Value)
            {
                LightBulbState("D0,HIGH");
            }
            else
            {
                LightBulbState("D0,LOW");
            }
        }

        private void LightBulb2_OnToggled(object sender, ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.LightBulb2Toogled = LightBulb2_switch.IsToggled;

            if (e.Value)
            {
                LightBulbState("D1,HIGH");
            }
            else
            {
                LightBulbState("D1,LOW");
            }
        }

        private void LightBulb3_OnToggled(object sender, ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.LightBulb3Toogled = LightBulb3_switch.IsToggled;

            if (e.Value)
            {
                LightBulbState("D2,HIGH");
            }
            else
            {
                LightBulbState("D2,LOW");
            }
        }

        private void LightBulb4_OnToggled(object sender, ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.LightBulb4Toogled = LightBulb4_switch.IsToggled;

            if (e.Value)
            {
                LightBulbState("D3,HIGH");
            }
            else
            {
                LightBulbState("D3,LOW");
            }
        }


        private void LightBulb5_OnToggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.LightBulb5Toogled = LightBulb5_switch.IsToggled;

            if (e.Value)
            {
                LightBulbState("D4,HIGH");
            }
            else
            {
                LightBulbState("D4,LOW");
            }
        }

        private void LightBulb6_OnToggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.LightBulb6Toogled = LightBulb6_switch.IsToggled;

            if (e.Value)
            {
                LightBulbState("D5,HIGH");
            }
            else
            {
                LightBulbState("D5,LOW");
            }
        }

        private void LightBulb7_OnToggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.LightBulb7Toogled = LightBulb7_switch.IsToggled;

            if (e.Value)
            {
                LightBulbState("A1,HIGH");
                LightBulbState("A2,HIGH");
            }
            else
            {
                LightBulbState("A1,LOW");
                LightBulbState("A2,LOW");
            }
        }


    }
}
