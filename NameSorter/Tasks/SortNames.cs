using System;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	// Sort names into alphabetical order.
	public class SortNames
	{
		
		public static void PerformSort(List<Person> entryList, int orderFlag)
		{
			entryList.Sort(NameOrder.CompareEntries);
			
			if (orderFlag <= 0)
			{
				entryList.Reverse();
			}
		}
	}
}