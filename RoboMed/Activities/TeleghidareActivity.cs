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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.teleghidare);


            // Create your application here
        }

    }
}