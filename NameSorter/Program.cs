using System;
using System.Collections.Generic;
using NameSorter.Common;
using NameSorter.Tasks;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] scriptArgs)
        {
			string inputFilePath = "";
			string outputFilePath = "";
			bool fileSizeValid = false;
			string[] inputLines = null;
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
					inputLines = ReadInputFile.GetLines(inputFilePath);
					peopleEntries = ParseNames.IterateLines(inputLines);
					SortNames.PerformSort(peopleEntries);
					outputLines = WriteOutputFile.PrepareLines(peopleEntries);
					resultsSaved = WriteOutputFile.SaveResults(outputFilePath, outputLines);
				}
				
				if (resultsSaved == true)
				{
					Console.WriteLine("Save successful");
				}
				
			}
			catch(Exception flaggedError)
			{
				Console.WriteLine("ERROR: " + flaggedError.Message);
			}
        }
    }
}
