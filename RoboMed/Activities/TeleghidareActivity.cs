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
    public class TeleghidareActivity : AppCompatActivity

    {
        ImageButton upButton;
        ImageButton downButton;
        ImageButton leftButton;
        ImageButton rightButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.teleghidare);

            upButton = FindViewById<ImageButton>(Resource.Id.btnFata);
            upButton.Click += UpClick;

            downButton = FindViewById<ImageButton>(Resource.Id.btnSpate);
            downButton.Click += DownClick;

            leftButton = FindViewById<ImageButton>(Resource.Id.btnStanga);
            leftButton.Click += LeftClick;

            rightButton = FindViewById<ImageButton>(Resource.Id.btnDreapta);
            rightButton.Click += RightClick;

            // Create your application here
        }

        private void RightClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Dreapta", ToastLength.Long).Show();
        }

        private void LeftClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Stanga", ToastLength.Long).Show();
        }

        private void DownClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Spate", ToastLength.Long).Show();
        }

        private void UpClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Fata", ToastLength.Long).Show();
        }
    }
}