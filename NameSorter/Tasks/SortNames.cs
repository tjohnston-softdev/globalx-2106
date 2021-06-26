using System;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	// Sort names into alphabetical order.
	public class SortNames
	{
		
		public static void PerformSort(List<Person> entryList)
		{
			entryList.Sort(NameOrder.CompareEntries);
		}
	}
}