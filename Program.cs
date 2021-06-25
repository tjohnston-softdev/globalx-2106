using System;
using System.Collections.Generic;
using globalX.Common;
using globalX.Tasks;

namespace globalX
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
			
			try
			{
				inputFilePath = InputArgs.ReadInputPath(scriptArgs);
				outputFilePath = InputArgs.ReadOutputPath(scriptArgs);
				fileSizeValid = ReadInputFile.ValidateSize(inputFilePath);
				
				if (fileSizeValid == true)
				{
					inputLines = ReadInputFile.GetLines(inputFilePath);
					peopleEntries = ParseNames.IterateLines(inputLines);
					Console.WriteLine(peopleEntries.Count);
				}
				
			}
			catch(Exception flaggedError)
			{
				Console.WriteLine(flaggedError.Message);
			}
        }
    }
}
