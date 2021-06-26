using System;

namespace NameSorter.Common
{
	// Determines sort order between entries.
	public class NameOrder
	{
		public static int CompareEntries(Person x, Person y)
		{
			// Names are case-insensitive.
			string xLast = x.lastName.ToLower();
			string yLast = y.lastName.ToLower();
			string xGiven = x.givenNames.ToLower();
			string yGiven = y.givenNames.ToLower();
			
			// Perform comparisons.
			int lastComp = xLast.CompareTo(yLast);
			int givenComp = xGiven.CompareTo(yGiven);
			
			int resultFlag = 0;
			
			if (lastComp != 0)
			{
				// Sort by last name.
				resultFlag = lastComp;
			}
			else if (givenComp != 0)
			{
				// Sort by given name.
				resultFlag = givenComp;
			}
			else
			{
				// Tied
				resultFlag = 0;
			}
			
			return resultFlag;
		}
	}
}