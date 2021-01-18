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
    [Activity(Label = "Account_Settings")]
    public class Account_Settings : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Account_Settings);

            Button button_Add_Card = FindViewById<Button>(Resource.Id.btn_add_card);

            button_Add_Card.Click += delegate { StartActivity(typeof(Add_Card)); };

            Button button_Change_Password = FindViewById<Button>(Resource.Id.btn_change_password);

            button_Change_Password.Click += delegate { StartActivity(typeof(Change_Password)); };

            Button button_Back = FindViewById<Button>(Resource.Id.btn_back);

            button_Back.Click += delegate { StartActivity(typeof(Home)); };
        }
    }
}