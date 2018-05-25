using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace WifiPhotonHouse
{
    public partial class App : Application
    {
        private const string LightBulb1ToggledKey = "LightBulb1Toggled";
        private const string LightBulb2ToggledKey = "LightBulb2Toggled";
        private const string LightBulb3ToggledKey = "LightBulb3Toggled";
        private const string LightBulb4ToggledKey = "LightBulb4Toggled";
        private const string LightBulb5ToggledKey = "LightBulb5Toggled";
        private const string LightBulb6ToggledKey = "LightBulb6Toggled";
        private const string LightBulb7ToggledKey = "LightBulb7Toggled";
        private const string FanSliderValueKey = "FanSliderValue";


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#008975")
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public bool LightBulb1Toogled
        {
            get
            {
                if (Properties.ContainsKey(LightBulb1ToggledKey))
                {
                    return (bool)Properties[LightBulb1ToggledKey];
                }
                else
                {
                    return false;
                }
            }
            set { Properties[LightBulb1ToggledKey] = value; }
        }

        public bool LightBulb2Toogled
        {
            get
            {
                if (Properties.ContainsKey(LightBulb2ToggledKey))
                {
                    return (bool)Properties[LightBulb2ToggledKey];
                }
                else
                {
                    return false;
                }
            }
            set { Properties[LightBulb2ToggledKey] = value; }
        }

        public bool LightBulb3Toogled
        {
            get
            {
                if (Properties.ContainsKey(LightBulb3ToggledKey))
                {
                    return (bool)Properties[LightBulb3ToggledKey];
                }
                else
                {
                    return false;
                }
            }
            set { Properties[LightBulb3ToggledKey] = value; }
        }

        public bool LightBulb4Toogled
        {
            get
            {
                if (Properties.ContainsKey(LightBulb4ToggledKey))
                {
                    return (bool)Properties[LightBulb4ToggledKey];
                }
                else
                {
                    return false;
                }
            }
            set { Properties[LightBulb4ToggledKey] = value; }
        }

        public bool LightBulb5Toogled
        {
            get
            {
                if (Properties.ContainsKey(LightBulb5ToggledKey))
                {
                    return (bool)Properties[LightBulb5ToggledKey];
                }
                else
                {
                    return false;
                }
            }
            set { Properties[LightBulb5ToggledKey] = value; }
        }

        public bool LightBulb6Toogled
        {
            get
            {
                if (Properties.ContainsKey(LightBulb6ToggledKey))
                {
                    return (bool)Properties[LightBulb6ToggledKey];
                }
                else
                {
                    return false;
                }
            }
            set { Properties[LightBulb6ToggledKey] = value; }
        }

        public bool LightBulb7Toogled
        {
            get
            {
                if (Properties.ContainsKey(LightBulb7ToggledKey))
                {
                    return (bool)Properties[LightBulb7ToggledKey];
                }
                else
                {
                    return false;
                }
            }
            set { Properties[LightBulb7ToggledKey] = value; }
        }


        public double FanSliderValue
        {
            get
            {
                if (Properties.ContainsKey(FanSliderValueKey))
                {
                    return (double)Properties[FanSliderValueKey];
                }
                else
                {
                    return 20;
                }
            }
            set { Properties[FanSliderValueKey] = value; }
        }
    }
}
