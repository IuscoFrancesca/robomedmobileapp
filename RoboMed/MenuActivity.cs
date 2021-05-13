using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboMed
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MenuActivity : AppCompatActivity
    {
        Button disconnectionButton;
        Button alarmsButton;
        Button changeButton;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.menu);


            disconnectionButton = FindViewById<Button>(Resource.Id.btnDisconnect);
            disconnectionButton.Click += DisconnectionClick;

            alarmsButton = FindViewById<Button>(Resource.Id.btnAlarms);
            alarmsButton.Click += AlarmsClick;


            changeButton = FindViewById<Button>(Resource.Id.btnChange);
            changeButton.Click += ChangeClick;


            // Create your application here
        }

        private void ChangeClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ChangeActivity));
            StartActivity(intent);
        }

        private void AlarmsClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AlarmsActivity));
            StartActivity(intent);
        }

        private void DisconnectionClick(object sender, EventArgs e)
        {
            Finish();

        }
    }
}
