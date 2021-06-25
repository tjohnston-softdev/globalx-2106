using System;
using System.IO;
using System.Security;

namespace globalX.Tasks
{
	public class ReadInputFile
	{
		private static int maxSize = 1000000;
		
		public static bool ValidateSize(string inpPath)
		{
			FileInfo inpInfo = null;
			bool validRes = false;
			
			try
			{
				inpInfo = new FileInfo(inpPath);
				validRes = CheckBytes(inpInfo.Length);
			}
			catch(ArgumentException argErr)
			{
				throw new Exception("Input file path is invalid or empty.");
			}
			catch(SecurityException secErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			catch(UnauthorizedAccessException accessErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			catch(PathTooLongException lengthErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			catch(NotSupportedException supportErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			catch(Exception otherErr)
			{
				throw otherErr;
			}
			
			
			return validRes;
		}
		
		private static bool CheckBytes(long givenBytes)
		{
			bool checkRes = false;
			
			if (givenBytes > 0 && givenBytes <= maxSize)
			{
				checkRes = true;
			}
			else if (givenBytes > maxSize)
			{
				throw new Exception("Input text file cannot be larger than 1MB.");
			}
			else
			{
				throw new Exception("Input text file cannot be empty.");
			}
			
			return checkRes;
		}
	}
}