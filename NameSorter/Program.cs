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
            string[] outputLines = null;
			bool resultsSaved = false;
			
			try
			{
				// Read cmd arguments.
				string inputFilePath = InputArgs.ReadInputPath(scriptArgs);
				int sortOrderFlag = InputArgs.ReadOrderFlag(scriptArgs);
				string outputFilePath = InputArgs.ReadOutputPath(scriptArgs);
				
				// Validate input file size.
				bool fileSizeValid = ReadInputFile.ValidateSize(inputFilePath);
				
				if (fileSizeValid)
				{
					// Parse input and sort names.
                    List<Person> peopleEntries = CallInputRead(inputFilePath);
					SortNames.PerformSort(peopleEntries, sortOrderFlag);
					
					// Write output file.
					outputLines = WriteOutputFile.PrepareLines(peopleEntries);
					resultsSaved = WriteOutputFile.SaveResults(outputFilePath, outputLines);
				}
				
				if (resultsSaved)
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
