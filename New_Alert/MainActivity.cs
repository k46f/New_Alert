using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace New_Alert
{
    [Activity(Label = "New_Alert", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button SButton = FindViewById<Button>(Resource.Id.button1);
            TextView TText = FindViewById<TextView>(Resource.Id.textView1);


            SButton.Click += delegate {

                var AName = (EditText)FindViewById(Resource.Id.editText1);
                var ALName = (EditText)FindViewById(Resource.Id.editText2);

                String Name = AName.Text;
                String LName = ALName.Text;

                AlertDialog.Builder alert = new AlertDialog.Builder(this);
                alert.SetTitle("Hey! " + Name);
                alert.SetMessage("Hi! " + Name + LName);

                alert.SetNegativeButton("Back", (senderAlert, args) => {
                    
                });

                Dialog dialog = alert.Create();
                dialog.Show();
            };


        }
    }
}

