using System;

namespace NameSorter.Tasks
{
	// Read command line arguments.
	public class InputArgs
	{
		// Input path.
		public static string ReadInputPath(string[] argArray)
		{
			string pathRes = "";
			
			try
			{
				pathRes = argArray[0].ToLower();
			}
			catch
			{
				throw new Exception("Input file path is required.");
			}
			
			return pathRes;
		}
		
		
		// Output path.
		public static string ReadOutputPath(string[] argArray)
		{
			string pathRes = "./sorted-names-list.txt";
			
			if (argArray.Length > 1)
			{
				pathRes = argArray[1].ToLower();
			}
			
			return pathRes;
		}
		
		public static int ReadOrderFlag(string[] argArray)
		{
			string argVal = "";
			int flagRes = 1;
			
			if (argArray.length > 2)
			{
				argVal = argArray[2];
				flagRes = Int32.Parse(argVal);
			}
			
			return flagRes;
		}
	}
}