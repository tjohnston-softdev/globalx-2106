namespace NameSorter.Common
{
	// Determines sort order between entries.
	public class NameOrder
	{
		public static int CompareEntries(Person x, Person y)
		{
			// Names are case-insensitive.
			string xLast = x.LastName.ToLower();
			string yLast = y.LastName.ToLower();
			string xGiven = x.GivenNames.ToLower();
			string yGiven = y.GivenNames.ToLower();
			
			// Perform comparisons.
			int lastComp = xLast.CompareTo(yLast);
			int givenComp = xGiven.CompareTo(yGiven);

            int resultFlag;
			
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