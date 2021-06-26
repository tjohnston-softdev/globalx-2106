using System;

namespace NameSorter.Common
{
	// Person name object.
	public class Person
	{
		// Private properties.
		private int pEntryID = -1;
		private string pLastName = "";
		private string pGivenNames = "";
		
		// Base constructor.
		private Person(int idVal, string lastVal, string givenVal)
		{
			pEntryID = idVal;
			pLastName = lastVal;
			pGivenNames = givenVal;
		}
		
		// First name only.
		public static Person OneName(int idArg, string[] nameArr)
		{
			string nameStr = nameArr[0];
			Person objectRes = new Person(idArg, "", nameStr);
			return objectRes;
		}
		
		// First, Last.
		public static Person TwoNames(int idArg, string[] nameArr)
		{
			string firstStr = nameArr[0];
			string lastStr = nameArr[1];
			Person objectRes = new Person(idArg, lastStr, firstStr);
			return objectRes;
		}
		
		// First, Middle, Last.
		public static Person MoreNames(int idArg, string[] nameArr)
		{
			int lastIndex = -1;
			string lastStr = "";
			string givenStr = "";
			
			// Read last name.
			lastIndex = nameArr.Length - 1;
			lastStr = nameArr[lastIndex];
			
			// Join given names together.
			givenStr = String.Join(" ", nameArr, 0, lastIndex);
			
			
			Person objectRes = new Person(idArg, lastStr, givenStr);
			return objectRes;
		}
		
		
		// Public properties (read-only)
		
		public int entryID
		{
			get {return pEntryID;}
		}
		
		public string lastName
		{
			get {return pLastName;}
		}
		
		public string givenNames
		{
			get {return pGivenNames;}
		}
	}
}