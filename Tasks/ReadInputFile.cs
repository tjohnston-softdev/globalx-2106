using System;
using System.IO;

namespace globalX.Tasks
{
	public class ReadInputFile
	{
		private static int maxSize = 1000000;
		
		public static bool ValidateSize(string inpPath)
		{
			FileInfo inpInfo = new FileInfo(inpPath);
			bool validRes = false;
			
			if (inpInfo.Length > 0 && inpInfo.Length <= maxSize)
			{
				validRes = true;
			}
			else if (inpInfo.Length > maxSize)
			{
				throw new Exception("Input text file cannot be larger than 1MB.");
			}
			else
			{
				throw new Exception("Input text file cannot be empty.");
			}
			
			return validRes;
		}
	}
}