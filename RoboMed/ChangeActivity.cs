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
    public class ChangeActivity : AppCompatActivity
    {
        Button remoteButton;
        Button teleghidareButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.modeChange);


            remoteButton = FindViewById<Button>(Resource.Id.btnRemote);
            remoteButton.Click += RemoteClick;

            teleghidareButton = FindViewById<Button>(Resource.Id.btnTeleghidare);
            teleghidareButton.Click += TeleghidareClick;


            // Create your application here
        }

        private void TeleghidareClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Controlul print teleghidare activat", ToastLength.Long).Show();
            Intent intent = new Intent(this, typeof(TeleghidareActivity));
            StartActivity(intent);
        }

        private async void RemoteClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Controlul de la distanta activat", ToastLength.Long).Show();
            Intent intent = new Intent(this, typeof(MenuActivity));
            StartActivity(intent);
        }
    }
}