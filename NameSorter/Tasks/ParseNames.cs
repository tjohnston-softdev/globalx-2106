using System.Text.RegularExpressions;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	// Parse input names into objects.
	public class ParseNames
	{
		// RegEx flags whitespace.
		private static readonly string _excessWhitespace = @"(\s+)";
		
		public static List<Person> IterateLines(string[] linesArr)
		{
            int idNumber = 1;
			List<Person> loopRes = new List<Person>();
			
			// Every input line.
			for (int lineIndex = 0; lineIndex < linesArr.Length; lineIndex++)
			{
                string[] currentParts = new string[0];

                // Read current line and sanitize whitespace.
				string currentLine = linesArr[lineIndex];
				currentLine = currentLine.Trim();
				currentLine = Regex.Replace(currentLine, _excessWhitespace, " ");
				
				if (currentLine.Length > 0)
				{
					// Split by words.
					currentParts = currentLine.Split(" ");
				}
				
				if (currentParts.Length == 1)
				{
					// First name only.
					Person currentPerson = Person.OneName(idNumber, currentParts);
					loopRes.Add(currentPerson);
                    idNumber += 1;
                }
				else if (currentParts.Length == 2)
				{
					// First and last name.
					Person currentPerson = Person.TwoNames(idNumber, currentParts);
					loopRes.Add(currentPerson);
                    idNumber += 1;
                }
				else if (currentParts.Length == 3 || currentParts.Length == 4)
				{
					// First, middle, and last names.
					Person currentPerson = Person.MoreNames(idNumber, currentParts);
					loopRes.Add(currentPerson);
                    idNumber += 1;
                }
			}
			
			return loopRes;
		}
	}
}