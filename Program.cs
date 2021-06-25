using System;
using globalX.Tasks;

namespace globalX
{
    class Program
    {
        static void Main(string[] scriptArgs)
        {
			string inputFilePath = InputArgs.readInputPath(scriptArgs);
			string outputFilePath = InputArgs.readOutputPath(scriptArgs);
			
			Console.WriteLine("Input Path: " + inputFilePath);
			Console.WriteLine("Output Path: " + outputFilePath);
        }
    }
}
