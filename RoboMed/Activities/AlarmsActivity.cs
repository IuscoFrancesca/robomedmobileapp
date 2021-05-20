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
    public class AlarmsActivity : AppCompatActivity
    {
        Button saveButton;
        Button viewButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.alarms);

            saveButton = FindViewById<Button>(Resource.Id.btnSave);
            saveButton.Click += SaveClick;

            viewButton = FindViewById<Button>(Resource.Id.btnView);
            viewButton.Click += ViewClick;

            // Create your application here
        }

        private void ViewClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ViewAlarmsActivity));
            StartActivity(intent);
        }

        private void SaveClick(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Alarmele au fost salvate", ToastLength.Long).Show();
        }
    }
}