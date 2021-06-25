using System;
using System.IO;
using System.Security;
using System.Text;

namespace globalX.Tasks
{
	public class ReadInputFile
	{
		private static int maxSize = 1000000;
		
		public static bool ValidateSize(string inpPath)
		{
			FileInfo inpInfo = null;
			bool validRes = false;
			
			try
			{
				inpInfo = new FileInfo(inpPath);
				validRes = CheckBytes(inpInfo.Length);
			}
			/*
			catch(ArgumentException argErr)
			{
				throw new Exception("Input file path is invalid or empty.");
			}
			catch(SecurityException secErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			catch(UnauthorizedAccessException accessErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			catch(PathTooLongException lengthErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			catch(NotSupportedException supportErr)
			{
				throw new Exception("PLACEHOLDER");
			}
			*/
			catch(Exception otherErr)
			{
				throw new Exception(otherErr.Message);
			}
			
			
			return validRes;
		}
		
		
		public static string[] GetLines(string inpPath)
		{
			string[] linesRes = null;
			
			try
			{
				linesRes = File.ReadAllLines(inpPath, Encoding.UTF8);
			}
			catch
			{
				throw new Exception("PLACEHOLDER");
			}
			
			return linesRes;
		}
		
		
		public static void DemoLines(string[] linesArr)
		{
			int lineCount = linesArr.Length;
			string first = linesArr[0];
			string last = linesArr[lineCount - 1];
			
			Console.WriteLine("First: " + first);
			Console.WriteLine("Last: " + last);
		}
		
		private static bool CheckBytes(long givenBytes)
		{
			bool checkRes = false;
			
			if (givenBytes > 0 && givenBytes <= maxSize)
			{
				checkRes = true;
			}
			else if (givenBytes > maxSize)
			{
				throw new Exception("Input text file cannot be larger than 1MB.");
			}
			else
			{
				throw new Exception("Input text file cannot be empty.");
			}
			
			return checkRes;
		}
	}
}