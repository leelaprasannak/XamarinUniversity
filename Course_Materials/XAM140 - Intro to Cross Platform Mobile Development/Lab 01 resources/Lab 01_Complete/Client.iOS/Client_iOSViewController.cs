using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Lab01;

namespace Client.iOS
{
	public partial class Client_iOSViewController : UIViewController
	{
		private int index;
		private string[] item=DataProvider.GetRecords();

		public Client_iOSViewController () : base ("Client_iOSViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Create a button and add it to the view
			UIButton button = new UIButton (UIButtonType.RoundedRect);
			button.Frame = new RectangleF (0, 50, View.Frame.Width, 32);
			button.SetTitle ("Click Me!", UIControlState.Normal);
			View.AddSubview (button);

			// Modify the button's handler to consume data from the DataProvider and
			// display the next item in the list based on it's value
			button.TouchUpInside += (sender, e) => {
				// Display next instructor from the list
				button.SetTitle (string.Format ("Speaker {0} - {1}", index+1, item[index]), UIControlState.Normal);

				// Inrement the list and wrap back around to the top
				// when the end is reached
				if (++index>=item.Length ) index=0;    
			};

		}
	}
}

