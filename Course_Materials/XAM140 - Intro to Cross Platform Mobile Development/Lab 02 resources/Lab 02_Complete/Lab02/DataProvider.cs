using System;

namespace Lab02
{
	/// <summary>
	/// Provides shared data to each platform specific project in the solution
	/// </summary>
	public class DataProvider
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Lab01.DataProvider"/> class.
		/// </summary>
		public DataProvider ()
		{
		}
		#endregion 

		#region Static Methods
		/// <summary>
		/// Returns all records for this data provider
		/// </summary>
		/// <returns>A string array containing all of the records for this data provider</returns>
		public static string[] GetRecords() {

			// Build items and return
			string[] items = new string[] {"Miguel de Icaza", "Nat Friedman", "Bart Decrem", "Scott Hanselman", "Craig Dunn"};

			return items;
		}
		#endregion
	}
}

