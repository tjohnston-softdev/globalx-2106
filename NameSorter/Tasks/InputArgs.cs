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
		
		
		// Sort order flag
		public static int ReadOrderFlag(string[] argArray)
		{
			string argVal = "";
			int flagRes = 1;
			
			if (argArray.Length > 1)
			{
				argVal = argArray[1];
				flagRes = Int32.Parse(argVal);
			}
			
			return flagRes;
		}
		
		
		
		// Output path.
		public static string ReadOutputPath(string[] argArray)
		{
			string pathRes = "./sorted-names-list.txt";
			
			if (argArray.Length > 2)
			{
				pathRes = argArray[2].ToLower();
			}
			
			return pathRes;
		}
		
	}
}