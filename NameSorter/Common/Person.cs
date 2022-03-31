using System;

namespace NameSorter.Common
{
	// Person name object.
	public class Person
	{
		// Private properties.
		private int _entryId;
		private string _lastName;
        private string _givenNames;
		
		// Base constructor.
		private Person(int idVal, string lastVal, string givenVal)
		{
            _entryId = idVal;
            _lastName = lastVal;
            _givenNames = givenVal;
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
            // Read last name.
			int lastIndex = nameArr.Length - 1;
			string lastStr = nameArr[lastIndex];
			
			// Join given names together.
			string givenStr = String.Join(" ", nameArr, 0, lastIndex);
			
			
			return new Person(idArg, lastStr, givenStr);
        }
		
		
		// Public properties (read-only)
		
		public int EntryId => _entryId;

        public string LastName => _lastName;

        public string GivenNames => _givenNames;
    }
}