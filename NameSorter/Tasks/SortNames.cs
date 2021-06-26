using System;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	public class SortNames
	{
		
		public static void PerformSort(List<Person> entryList)
		{
			entryList.Sort(CompareEntries);
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