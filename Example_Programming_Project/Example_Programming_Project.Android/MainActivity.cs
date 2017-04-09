using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace Example_Programming_Project.Droid
{
    [Activity(Label = "Example_Programming_Project.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 0;

        string username = "Jeremy";

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
            Button btn_submit = FindViewById<Button>(Resource.Id.button1);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);

                Console.WriteLine(string.Format("{0} klicks, Du heißt: {1} ", count, username));
			};

           
		}
	}
}


