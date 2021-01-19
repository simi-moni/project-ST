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
    [Activity(Label = "ControlView")]
    public class ControlView : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.ControlView);

            Button button_Buy = FindViewById<Button>(Resource.Id.btn_buy_ticket);

            button_Buy.Click += delegate { StartActivity(typeof(Buy)); };

            Button button_Scan = FindViewById<Button>(Resource.Id.btn_scan_qr);

            button_Scan.Click += delegate { StartActivity(typeof(Buy)); };

            Button button_Show_QR = FindViewById<Button>(Resource.Id.btn_show_qr);

            button_Show_QR.Click += delegate { StartActivity(typeof(QR)); };

            Button button_History = FindViewById<Button>(Resource.Id.btn_history);

            button_History.Click += delegate { StartActivity(typeof(History)); };

            Button button_Account_Settings = FindViewById<Button>(Resource.Id.btn_acc_settings);

            button_Account_Settings.Click += delegate { StartActivity(typeof(Account_Settings)); };

            Button button_Logout = FindViewById<Button>(Resource.Id.btn_logout);

            button_Logout.Click += delegate { StartActivity(typeof(LogIn)); };
        }
    }
}