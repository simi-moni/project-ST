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
    [Activity(Label = "Add_Card")]
    public class Add_Card : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.Add_Card);

            Button button_Back = FindViewById<Button>(Resource.Id.btn_back);

            button_Back.Click += delegate { StartActivity(typeof(Account_Settings)); };
        }
    }
}