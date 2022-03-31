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
            string[] linesRes = new string[entryList.Count];
			
			// Every name entry.
			for (int personIndex = 0; personIndex < entryList.Count; personIndex++)
			{
				// Given names and last name.
				Person currentPerson = entryList[personIndex];
				string currentLine = currentPerson.GivenNames + " " + currentPerson.LastName;
				linesRes[personIndex] = currentLine;
			}
			
			return linesRes;
		}
		
		// Save output file.
		public static bool SaveResults(string outputPath, string[] linesArr)
        {
            bool writeRes;

            try
			{
				// Perform write.
				File.WriteAllLines(outputPath, linesArr);
				writeRes = true;
			}
			catch(Exception writeErr)
			{
				// Error caught.
				string fileErrMsg = ErrorMessages.WriteFileMessage("saving", "output", writeErr);
                throw new Exception(fileErrMsg);
			}
			
			return writeRes;
		}
	}
}