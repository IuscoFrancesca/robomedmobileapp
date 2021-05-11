﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace RoboMed
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, NoHistory = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText username;
        EditText password;
        Button loginButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            username = FindViewById<EditText>(Resource.Id.txtName);
            password = FindViewById<EditText>(Resource.Id.txtPassword);
            loginButton = FindViewById<Button>(Resource.Id.btnLogin);

            loginButton.Click += LoginClick;
        }

        private void LoginClick(object sender, EventArgs e)
        {
            if(username.Text=="admin" && password.Text=="12345")
            {
                Intent intent = new Intent(this, typeof(LoginActivity));
                StartActivity(intent);
                Finish();


                //Toast.MakeText(this, "Successfull Loghin", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "Invalid Loghin",ToastLength.Long).Show();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}