using System;
using System.Collections.Generic;
using NameSorter.Common;

namespace NameSorter.Tasks
{
	public class SortNames
	{
		
		public static void PerformSort(List<Person> entryList)
		{
			entryList.Sort(NameOrder.CompareEntries);
		}
	}
}