using System;
using System.IO;
using System.Text;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	// Open and read input file.
	public class ReadInputFile
	{
		// 1 megabyte.
		private static int maxSize = 1000000;
		
		
		// Validate file size.
		public static bool ValidateSize(string inpFilePath)
		{
            bool validRes;
			
			try
			{
				long retrievedSize = GetBytes(inpFilePath);
				validRes = CheckBytes(retrievedSize);
			}
			catch(Exception validErr)
			{
				// Error caught.
				throw new Exception(validErr.Message);
			}
			
			
			return validRes;
		}
		
		// Read file as array of lines.
		public static string[] GetLines(string inpFilePath)
		{
			string[] linesRes;

            try
			{
				linesRes = File.ReadAllLines(inpFilePath, Encoding.UTF8);
			}
			catch(Exception linesErr)
			{
				string fileErrMsg = ErrorMessages.WriteFileMessage("read", "input", linesErr);
				throw new Exception(fileErrMsg);
			}
			
			return linesRes;
		}
		
		// Read size of input file in bytes.
		private static long GetBytes(string inpPath)
		{
            long getRes;

            try
			{
				// Attempt open.
				FileInfo systemEntry = new FileInfo(inpPath);
				getRes = systemEntry.Length;
			}
			catch(Exception infoErr)
			{
				// Error opening input file.
				string fileErrMsg = ErrorMessages.WriteFileMessage("check", "input", infoErr);
				throw new Exception(fileErrMsg);
			}
			
			return getRes;
		}
		
		// Validate byte count.
		private static bool CheckBytes(long givenBytes)
        {
            bool checkRes = false;
            string sizeErrMsg;
			
			if (givenBytes > 0 && givenBytes <= maxSize)
			{
				checkRes = true;
			}
			else if (givenBytes > maxSize)
            {
                checkRes = false;
                sizeErrMsg = ErrorMessages.WriteInputSizeMessage("larger than 1MB");
				throw new Exception(sizeErrMsg);
			}
			else
            {
                checkRes = false;
                sizeErrMsg = ErrorMessages.WriteInputSizeMessage("empty");
				throw new Exception(sizeErrMsg);
			}
			
			return checkRes;
		}
	}
}