using System;

namespace NameSorter.Common
{
	// Common error messages.
	public class ErrorMessages
	{
		// File IO.
		public static string WriteFileMessage(string vAction, string vFile, Exception errObject)
		{
			string errType = errObject.GetType().Name;
			string writeRes = "";
			
			writeRes += "Could not successfully ";
			writeRes += vAction;
			writeRes += " ";
			writeRes += vFile;
			writeRes += " file. - ";
			writeRes += PrepareErrorDescription(errType);
			
			return writeRes;
		}
		
		
		// Input file size.
		public static string WriteInputSizeMessage(string vContext)
		{
			return "Input text file cannot be " + vContext;
        }
		
		
		// Parses IO exception into readable description.
		private static string PrepareErrorDescription(string eType)
        {
            string prepDesc;
			
			if (eType == "ArgumentException")
			{
				prepDesc = "Path string is empty or invalid.";
			}
			else if (eType == "SecurityException")
			{
				prepDesc = "Permission not granted.";
			}
			else if (eType == "UnauthorizedAccessException")
			{
				prepDesc = "Unauthorized access.";
			}
			else if (eType == "PathTooLongException")
			{
				prepDesc = "Path string is too long.";
			}
			else if (eType == "NotSupportedException")
			{
				prepDesc = "Path string is not supported. Please remove any special characters.";
			}
			else if (eType == "DirectoryNotFoundException")
			{
				prepDesc = "Directory not found.";
			}
			else if (eType == "IOException")
			{
				prepDesc = "IO failure.";
			}
			else if (eType == "FileNotFoundException")
			{
				prepDesc = "Does not exist.";
			}
			else
			{
				prepDesc = "Unknown reason.";
			}
			
			return prepDesc;
		}
	}
}