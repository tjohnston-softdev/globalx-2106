using NUnit.Framework;
using NameSorter.Common;

namespace NameSorter.Tests
{
    [TestFixture]
	public class OrderTests
    {	
		[Test]
		public void FirstLast()
		{
			string[] entryNamesA = {"Gene", "Diaz"};
			Person entryObjectA = Person.TwoNames(1, entryNamesA);
			
			string[] entryNamesB = {"Jule", "Vang"};
			Person entryObjectB = Person.TwoNames(2, entryNamesB);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(-1, flagRes);
		}
		
		[Test]
		public void FirstOnly()
		{
			string[] entryNamesA = {"First", "Last"};
			Person entryObjectA = Person.TwoNames(1, entryNamesA);
			
			string[] entryNamesB = {"Single"};
			Person entryObjectB = Person.OneName(2, entryNamesB);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(1, flagRes);
		}
		
		[Test]
		public void FirstMiddleLast()
		{
			string[] entryNamesA = {"Jordan", "Alan", "Burns"};
			Person entryObjectA = Person.MoreNames(1, entryNamesA);
			
			string[] entryNamesB = {"Dwayne", "Smith"};
			Person entryObjectB = Person.TwoNames(2, entryNamesB);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(-1, flagRes);
		}
		
		
		[Test]
		public void SameLastName()
		{
			string[] entryNamesA = {"Maureen", "Thomas"};
			Person entryObjectA = Person.TwoNames(1, entryNamesA);
			
			string[] entryNamesB = {"Ellen", "Thomas"};
			Person entryObjectB = Person.TwoNames(2, entryNamesB);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(1, flagRes);
		}
		
		[Test]
		public void DuplicateNames()
		{
			string[] dupeNames = {"Same", "Person"};
			Person entryObjectA = Person.TwoNames(1, dupeNames);
			Person entryObjectB = Person.TwoNames(2, dupeNames);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(0, flagRes);
		}
		
		[Test]
		public void CaseSensitivity()
		{
			string[] upperNames = {"EDWARD", "LAUREL", "HALL"};
			string[] lowerNames = {"edward", "laurel", "hall"};
			
			Person entryObjectA = Person.TwoNames(1, upperNames);
			Person entryObjectB = Person.TwoNames(2, lowerNames);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(0, flagRes);
		}
    }
}