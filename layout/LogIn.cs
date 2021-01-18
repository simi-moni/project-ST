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

namespace Project.Resources.layout
{
    [Activity(Label = "LogIn")]
    public class LogIn : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.LogIn);

            Button button_Forgot_Password = FindViewById<Button>(Resource.Id.btn_forgot_password);

            button_Forgot_Password.Click += delegate { StartActivity(typeof(Forgot_Password)); };

            Button button_LogIn = FindViewById<Button>(Resource.Id.btn_login);

            button_LogIn.Click += delegate { StartActivity(typeof(Home)); };

            Button button_Registration = FindViewById<Button>(Resource.Id.btn_register_here);

            button_Registration.Click += delegate { StartActivity(typeof(Registration)); };
        }
    }
}