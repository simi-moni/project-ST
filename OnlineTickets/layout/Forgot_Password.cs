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
    [Activity(Label = "Forgot_Password")]
    public class Forgot_Password : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Forgot_Password);

            Button button_Reset_Password = FindViewById<Button>(Resource.Id.btn_resset_password);

            button_Reset_Password.Click += delegate { StartActivity(typeof(LogIn)); };

            Button button_Registration = FindViewById<Button>(Resource.Id.btn_register_here);

            button_Registration.Click += delegate { StartActivity(typeof(Registration)); };

            Button button_to_Login = FindViewById<Button>(Resource.Id.btn_back);

            button_to_Login.Click += delegate { StartActivity(typeof(LogIn)); };
        }
    }
}