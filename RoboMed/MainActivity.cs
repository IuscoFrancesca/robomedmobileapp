using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using RoboMed.Services;
using System;
using System.Threading.Tasks;

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

        private async void LoginClick(object sender, EventArgs e)
        {
            var userService = new UserService();
            var token = await userService.Authenticate(username.Text, password.Text);
            // salveaza tokenul undeva ca sa il folosesti pentru restul request-urilor
            // aici un exemplu:
            // client.DefaultRequestHeaders.Authorization =
            //    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            if (username.Text=="admin" && password.Text=="12345")
            {
                Intent intent = new Intent(this, typeof(MenuActivity));
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