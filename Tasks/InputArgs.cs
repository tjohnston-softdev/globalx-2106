using System;

namespace globalX.Tasks
{
	public class InputArgs
	{
		public static string readInputPath(string[] argArray)
		{
			string pathRes = "";
			
			if (argArray.Length > 0)
			{
				pathRes = argArray[0].ToLower();
			}
			else
			{
				throw new Exception("ERROR: Input file path is required.");
			}
			
			return pathRes;
		}
		
		
		public static string readOutputPath(string[] argArray)
		{
			string pathRes = "./sorted-names-list.txt";
			
			if (argArray.Length > 1)
			{
				pathRes = argArray[1].ToLower();
			}
			
			return pathRes;
		}
	}
}