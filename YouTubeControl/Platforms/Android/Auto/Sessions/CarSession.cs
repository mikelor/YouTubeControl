using Android.Content;
using AndroidX.Car.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeControl.Platforms.Android.Auto.Screens;
using YouTubeControl.Platforms.Android;

namespace YouTubeControl.Platforms.Android.Auto.Sessions
{
    public class CarSession : Session
    {
        public override Screen OnCreateScreen(Intent p0)
        {
            return new CarScreenMenu(CarContext);
        }
    }
}
