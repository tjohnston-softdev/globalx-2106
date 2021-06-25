using System;
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
			
			try
			{
				inputFilePath = InputArgs.ReadInputPath(scriptArgs);
				outputFilePath = InputArgs.ReadOutputPath(scriptArgs);
				fileSizeValid = ReadInputFile.ValidateSize(inputFilePath);
				
				if (fileSizeValid == true)
				{
					inputLines = ReadInputFile.GetLines(inputFilePath);
					ReadInputFile.DemoLines(inputLines);
				}
				
			}
			catch(Exception flaggedError)
			{
				Console.WriteLine(flaggedError.Message);
			}
        }
    }
}
