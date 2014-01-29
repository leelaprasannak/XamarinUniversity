using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Lab01;

namespace Client.Droid
{
	[Activity (Label = "Client.Droid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		// Set the index to point to the first record available
		// and get the 
		private int index = 0;
		private string[] item=DataProvider.GetRecords();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			// Modify the button's handler to consume data from the DataProvider and
			// display the next item in the list based on it's value
			button.Click += delegate {
				// Display next instructor from the list
				button.Text = string.Format ("Speaker {0} - {1}", index+1, item[index]);

				// Inrement the list and wrap back around to the top
				// when the end is reached
				if (++index>=item.Length ) index=0;
			};
		}
	}
}


