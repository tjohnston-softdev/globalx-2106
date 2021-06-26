using System;
using System.IO;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	public class WriteOutputFile
	{	
		public static string[] PrepareLines(List<Person> entryList)
		{
			int personIndex = 0;
			Person currentPerson = null;
			string currentLine = "";
			string[] linesRes = new string[entryList.Count];
			
			for (personIndex = 0; personIndex < entryList.Count; personIndex = personIndex + 1)
			{
				currentPerson = entryList[personIndex];
				currentLine = currentPerson.givenNames + " " + currentPerson.lastName;
				linesRes[personIndex] = currentLine;
			}
			
			return linesRes;
		}
		
		
		public static bool SaveResults(string outputPath, string[] linesArr)
		{
			bool writeRes = false;
			string fileErrMsg = "";
			
			try
			{
				File.WriteAllLines(outputPath, linesArr);
				writeRes = true;
			}
			catch(Exception writeErr)
			{
				fileErrMsg = ErrorMessages.WriteFileMessage("saving", "output", writeErr);
				throw new Exception(fileErrMsg);
			}
			
			return writeRes;
		}
	}
}