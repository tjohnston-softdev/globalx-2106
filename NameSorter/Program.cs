using System;
using System.Collections.Generic;
using NameSorter.Common;
using NameSorter.Tasks;

namespace NameSorter
{
    class Program
    {
        private static void Main(string[] scriptArgs)
        {
			string inputFilePath = "";
			string outputFilePath = "";
			bool fileSizeValid = false;
			
			List<Person> peopleEntries = new List<Person>();
			string[] outputLines = null;
			bool resultsSaved = false;
			
			try
			{
				inputFilePath = InputArgs.ReadInputPath(scriptArgs);
				outputFilePath = InputArgs.ReadOutputPath(scriptArgs);
				fileSizeValid = ReadInputFile.ValidateSize(inputFilePath);
				
				if (fileSizeValid == true)
				{
					peopleEntries = CallInputRead(inputFilePath);
					SortNames.PerformSort(peopleEntries);
					outputLines = WriteOutputFile.PrepareLines(peopleEntries);
					resultsSaved = WriteOutputFile.SaveResults(outputFilePath, outputLines);
				}
				
				if (resultsSaved == true)
				{
					DisplaySortedLines.Display(100, outputLines);
				}
				
			}
			catch(Exception flaggedError)
			{
				Console.WriteLine("ERROR: " + flaggedError.Message);
			}
        }
		
		private static List<Person> CallInputRead(string filePth)
		{
			string[] inputLines = ReadInputFile.GetLines(filePth);
			List<Person> readRes = ParseNames.IterateLines(inputLines);
			return readRes;
		}
    }
}
