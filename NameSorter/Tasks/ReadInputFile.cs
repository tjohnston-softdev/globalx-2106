using System;
using System.IO;
using System.Security;
using System.Text;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	public class ReadInputFile
	{
		private static int maxSize = 1000000;
		
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
				throw new Exception(validErr.Message);
			}
			
			
			return validRes;
		}
		
		
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
		
		
		private static long GetBytes(string inpPath)
		{
			FileInfo systemEntry = null;
			long getRes = -1;
			string fileErrMsg = "";
			
			try
			{
				systemEntry = new FileInfo(inpPath);
				getRes = systemEntry.Length;
			}
			catch(Exception infoErr)
			{
				fileErrMsg = ErrorMessages.WriteFileMessage("check", "input", infoErr);
				throw new Exception(fileErrMsg);
			}
			
			return getRes;
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