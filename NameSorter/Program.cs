using System;
using System.Collections.Generic;
using NameSorter.Common;
using NameSorter.Tasks;

namespace NameSorter
{
    // NameSorter - Main script file.
	class Program
    {
        private static void Main(string[] scriptArgs)
        {
			string inputFilePath = "";
			int sortOrderFlag = 0;
			string outputFilePath = "";
			bool fileSizeValid = false;
			
			List<Person> peopleEntries = new List<Person>();
			string[] outputLines = null;
			bool resultsSaved = false;
			
			try
			{
				// Read cmd arguments.
				inputFilePath = InputArgs.ReadInputPath(scriptArgs);
				sortOrderFlag = InputArgs.ReadOrderFlag(scriptArgs);
				outputFilePath = InputArgs.ReadOutputPath(scriptArgs);
				
				// Validate input file size.
				fileSizeValid = ReadInputFile.ValidateSize(inputFilePath);
				
				if (fileSizeValid == true)
				{
					// Parse input and sort names.
					peopleEntries = CallInputRead(inputFilePath);
					SortNames.PerformSort(peopleEntries, sortOrderFlag);
					
					// Write output file.
					outputLines = WriteOutputFile.PrepareLines(peopleEntries);
					resultsSaved = WriteOutputFile.SaveResults(outputFilePath, outputLines);
				}
				
				if (resultsSaved == true)
				{
					// Display sorted names to console. First 100 only.
					DisplaySortedLines.Display(100, outputLines);
				}
				
			}
			catch(Exception flaggedError)
			{
				// Display error.
				Console.WriteLine("ERROR: " + flaggedError.Message);
			}
        }
		
		private static List<Person> CallInputRead(string filePth)
		{
			// Read file line-by-line.
			string[] inputLines = ReadInputFile.GetLines(filePth);
			List<Person> readRes = ParseNames.IterateLines(inputLines);
			return readRes;
		}
    }
}
