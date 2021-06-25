using System;
using System.Collections.Generic;
using globalX.Common;

namespace globalX.Tasks
{
	public class SortNames
	{
		private static string excessWhitespace = @"(\s+)";
		
		public static void PerformSort(List<Person> entryList)
		{
			entryList.Sort(CompareEntries);
		}
		
		
		public static void DisplaySortResults(List<Person> entryList)
		{
			int index = 0;
			Person currentPerson = null;
			string currentLine = "";
			
			for (index = 0; index < entryList.Count; index = index + 1)
			{
				currentPerson = entryList[index];
				currentLine = currentPerson.givenNames + " " + currentPerson.lastName;
				Console.WriteLine(currentLine);
			}
		}
		
		
		private static int CompareEntries(Person x, Person y)
		{
			string xLastLower = x.lastName.ToLower();
			string yLastLower = y.lastName.ToLower();
			string xGivenLower = x.givenNames.ToLower();
			string yGivenLower = y.givenNames.ToLower();
			
			int lastComp = xLastLower.CompareTo(yLastLower);
			int givenComp = xGivenLower.CompareTo(yGivenLower);
			int orderComp = x.entryID.CompareTo(y.entryID);
			
			int resultFlag = 0;
			
			if (lastComp != 0)
			{
				resultFlag = lastComp;
			}
			else if (givenComp != 0)
			{
				resultFlag = givenComp;
			}
			else
			{
				resultFlag = orderComp;
			}
			
			return resultFlag;
		}
	}
}