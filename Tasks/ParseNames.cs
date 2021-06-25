using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using globalX.Common;

namespace globalX.Tasks
{
	public class ParseNames
	{
		private static string excessWhitespace = @"(\s+)";
		
		public static List<Person> IterateLines(string[] linesArr)
		{
			int lineIndex = 0;
			string currentLine = "";
			string[] currentParts = null;
			Person currentPerson = null;
			
			int idNumber = 1;
			List<Person> loopRes = new List<Person>();
			
			for (lineIndex = 0; lineIndex < linesArr.Length; lineIndex = lineIndex + 1)
			{
				currentLine = "";
				currentParts = new string[0];
				currentPerson = null;
				
				currentLine = linesArr[lineIndex];
				currentLine = currentLine.Trim();
				currentLine = Regex.Replace(currentLine, excessWhitespace, " ");
				
				if (currentLine.Length > 0)
				{
					currentParts = currentLine.Split(" ");
				}
				
				if (currentParts.Length == 1)
				{
					currentPerson = Person.OneName(idNumber, currentParts);
					loopRes.Add(currentPerson);
					idNumber = idNumber + 1;
				}
				else if (currentParts.Length == 2)
				{
					currentPerson = Person.TwoNames(idNumber, currentParts);
					loopRes.Add(currentPerson);
					idNumber = idNumber + 1;
				}
				else if (currentParts.Length == 3 || currentParts.Length == 4)
				{
					currentPerson = Person.MoreNames(idNumber, currentParts);
					loopRes.Add(currentPerson);
					idNumber = idNumber + 1;
				}
			}
			
			return loopRes;
		}
	}
}