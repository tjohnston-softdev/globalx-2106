using System;
using System.IO;
using System.Security;
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
			long retrievedSize = -1;
			bool validRes = false;
			
			try
			{
				retrievedSize = GetBytes(inpFilePath);
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
			string[] linesRes = null;
			string fileErrMsg = "";
			
			try
			{
				linesRes = File.ReadAllLines(inpFilePath, Encoding.UTF8);
			}
			catch(Exception linesErr)
			{
				fileErrMsg = ErrorMessages.WriteFileMessage("read", "input", linesErr);
				throw new Exception(fileErrMsg);
			}
			
			return linesRes;
		}
		
		// Read size of input file in bytes.
		private static long GetBytes(string inpPath)
		{
			FileInfo systemEntry = null;
			long getRes = -1;
			string fileErrMsg = "";
			
			try
			{
				// Attempt open.
				systemEntry = new FileInfo(inpPath);
				getRes = systemEntry.Length;
			}
			catch(Exception infoErr)
			{
				// Error opening input file.
				fileErrMsg = ErrorMessages.WriteFileMessage("check", "input", infoErr);
				throw new Exception(fileErrMsg);
			}
			
			return getRes;
		}
		
		// Validate byte count.
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