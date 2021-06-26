using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	// Parse input names into objects.
	public class ParseNames
	{
		// RegEx flags whitespace.
		private static string excessWhitespace = @"(\s+)";
		
		public static List<Person> IterateLines(string[] linesArr)
		{
			int lineIndex = 0;
			string currentLine = "";
			string[] currentParts = null;
			Person currentPerson = null;
			
			int idNumber = 1;
			List<Person> loopRes = new List<Person>();
			
			// Every input line.
			for (lineIndex = 0; lineIndex < linesArr.Length; lineIndex = lineIndex + 1)
			{
				currentLine = "";
				currentParts = new string[0];
				currentPerson = null;
				
				// Read current line and sanitize whitespace.
				currentLine = linesArr[lineIndex];
				currentLine = currentLine.Trim();
				currentLine = Regex.Replace(currentLine, excessWhitespace, " ");
				
				if (currentLine.Length > 0)
				{
					// Split by words.
					currentParts = currentLine.Split(" ");
				}
				
				if (currentParts.Length == 1)
				{
					// First name only.
					currentPerson = Person.OneName(idNumber, currentParts);
					loopRes.Add(currentPerson);
					idNumber = idNumber + 1;
				}
				else if (currentParts.Length == 2)
				{
					// First and last name.
					currentPerson = Person.TwoNames(idNumber, currentParts);
					loopRes.Add(currentPerson);
					idNumber = idNumber + 1;
				}
				else if (currentParts.Length == 3 || currentParts.Length == 4)
				{
					// First, middle, and last names.
					currentPerson = Person.MoreNames(idNumber, currentParts);
					loopRes.Add(currentPerson);
					idNumber = idNumber + 1;
				}
			}
			
			return loopRes;
		}
	}
}