using System;
using System.IO;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	// Saves sorted names output file.
	public class WriteOutputFile
	{	
		// Writes sorted name lines.
		public static string[] PrepareLines(List<Person> entryList)
		{
			int personIndex = 0;
			Person currentPerson = null;
			string currentLine = "";
			string[] linesRes = new string[entryList.Count];
			
			// Every name entry.
			for (personIndex = 0; personIndex < entryList.Count; personIndex = personIndex + 1)
			{
				// Given names and last name.
				currentPerson = entryList[personIndex];
				currentLine = currentPerson.givenNames + " " + currentPerson.lastName;
				linesRes[personIndex] = currentLine;
			}
			
			return linesRes;
		}
		
		// Save output file.
		public static bool SaveResults(string outputPath, string[] linesArr)
		{
			bool writeRes = false;
			string fileErrMsg = "";
			
			try
			{
				// Perform write.
				File.WriteAllLines(outputPath, linesArr);
				writeRes = true;
			}
			catch(Exception writeErr)
			{
				// Error caught.
				fileErrMsg = ErrorMessages.WriteFileMessage("saving", "output", writeErr);
				throw new Exception(fileErrMsg);
			}
			
			return writeRes;
		}
	}
}