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
			
			try
			{
				inputFilePath = InputArgs.ReadInputPath(scriptArgs);
				outputFilePath = InputArgs.ReadOutputPath(scriptArgs);
				fileSizeValid = ReadInputFile.ValidateSize(inputFilePath);
				
				Console.WriteLine("Successful");
			}
			catch(Exception flaggedError)
			{
				Console.WriteLine(flaggedError.Message);
			}
        }
    }
}
