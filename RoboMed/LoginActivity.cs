using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.AppCompat.App;

namespace RoboMed
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", NoHistory = false)]

    public class LoginActivity : AppCompatActivity
    {
        Button disconnectionButton;
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.mymenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.btnChange:
                    return true;
                case Resource.Id.btnView:
                    return true;
                case Resource.Id.btnDisconnect:
                    return true;

            }

            return base.OnOptionsItemSelected(item);
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.menu);


            disconnectionButton = FindViewById<Button>(Resource.Id.btnDisconnect);
            disconnectionButton.Click += DisconnectionClick;


            // Create your application here
        }

        private void DisconnectionClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(DisconnectionActivity));
            StartActivity(intent);
            Finish();
        }
    }
}