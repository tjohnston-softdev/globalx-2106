using System;

namespace globalX.Common
{
	public class Person
	{
		private int pEntryID = -1;
		private string pLastName = "";
		private string pGivenNames = "";
		
		private Person(int idVal, string lastVal, string givenVal)
		{
			pEntryID = idVal;
			pLastName = lastVal;
			pGivenNames = givenVal;
		}
		
		public static Person OneName(int idArg, string[] nameArr)
		{
			string nameStr = nameArr[0];
			Person objectRes = new Person(idArg, "", nameStr);
			return objectRes;
		}
		
		public static Person TwoNames(int idArg, string[] nameArr)
		{
			string firstStr = nameArr[0];
			string lastStr = nameArr[1];
			Person objectRes = new Person(idArg, lastStr, firstStr);
			return objectRes;
		}
		
		public static Person MoreNames(int idArg, string[] nameArr)
		{
			int lastIndex = nameArr.Length - 1;
			string lastStr = nameArr[lastIndex];
			string givenStr = String.Join(" ", nameArr, 0, lastIndex);
			Person objectRes = new Person(idArg, lastStr, givenStr);
			return objectRes;
		}
	}
}