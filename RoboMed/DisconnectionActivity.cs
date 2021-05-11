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
    public class DisconnectionActivity : AppCompatActivity
    {
        Button yesButton;
        Button noButton;
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
            SetContentView(Resource.Layout.disconnection);


            yesButton = FindViewById<Button>(Resource.Id.btnYes);
            yesButton.Click += YesClick;

            noButton = FindViewById<Button>(Resource.Id.btnNo);
            noButton.Click += NoClick;




            // Create your application here
        }

        private void NoClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(NoActivity));
            StartActivity(intent);
            Finish();
        }

        private void YesClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(YesActivity));
            StartActivity(intent);
            Finish();
        }

        
    }
}