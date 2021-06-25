using System;
using System.Collections.Generic;
using globalX.Common;

namespace globalX.Tasks
{
	public class SortNames
	{
		
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
			string xLast = x.lastName.ToLower();
			string yLast = y.lastName.ToLower();
			string xGiven = x.givenNames.ToLower();
			string yGiven = y.givenNames.ToLower();
			
			int lastComp = xLast.CompareTo(yLast);
			int givenComp = xGiven.CompareTo(yGiven);
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