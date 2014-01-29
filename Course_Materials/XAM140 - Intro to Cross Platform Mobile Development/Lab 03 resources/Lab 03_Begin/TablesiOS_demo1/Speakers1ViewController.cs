using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

//TODO: 3 - Uncomment the using statements
//using System.IO;
//using Lab03;

namespace EvolveLite {
	public class SpeakersViewController : UITableViewController {
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//TODO: 4 - Comment the first line and uncomment the second one
			string[] items = new string[] {"Miguel de Icaza", "Nat Friedman", "Bart Decrem", "Scott Hanselman"};
			//string[] items = DataProvider.GetRecords (File.Open ("Assets/Instructors.txt", FileMode.Open));

			TableView.Source = new SpeakersTableSource (items);
		}
	}
}