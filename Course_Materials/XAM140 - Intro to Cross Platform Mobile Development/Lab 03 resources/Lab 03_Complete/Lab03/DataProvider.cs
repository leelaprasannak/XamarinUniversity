using System;
using System.IO;

namespace Lab03
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
		public static string[] GetRecords(Stream stream) {
			string data;

			// Use a StreamReader to read the data 
			using (StreamReader sr = new StreamReader(stream)) 
				data = sr.ReadToEnd(); 

			// Break data into individual records
			char[] delimiterChars = {','};
			string[] items = data.Split(delimiterChars);

			// Return data
			return items;
		}
		#endregion
	}
}

