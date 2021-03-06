using System;

namespace NameSorter.Tasks
{
	// Display sorted names to console.
	public class DisplaySortedLines
	{	
		public static void Display(int maxDispCount, string[] linesArrObj)
		{
			if (linesArrObj.Length > 0)
			{
				RunLoop(maxDispCount, linesArrObj);
			}
			else
			{
				Console.WriteLine("No names sorted");
			}
		}
		
		// Loop name lines.
		private static void RunLoop(int dispCount, string[] linesArr)
		{
			int lineIndex = 0;
			int loopCutoff = Math.Min(dispCount, linesArr.Length);

            Console.WriteLine("Name sorting complete");
			Console.WriteLine("");
			
			while (lineIndex >= 0 && lineIndex < loopCutoff)
			{
				// Display current line.
				string currentLine = linesArr[lineIndex];
				Console.WriteLine(currentLine);
                lineIndex += 1;
            }
			
			
			if (lineIndex < linesArr.Length)
			{
				// Further names truncated.
				Console.WriteLine("");
				Console.WriteLine("[...]");
			}
		}
		
		
	}
}