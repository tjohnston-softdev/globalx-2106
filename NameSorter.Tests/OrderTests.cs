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
			Person entryObjectB = Person.TwoNames(2, entryNamesA);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(flagRes, -1);
		}
		
		[Test]
		public void FirstOnly()
		{
			string[] entryNamesA = {"First", "Last"};
			Person entryObjectA = Person.TwoNames(1, entryNamesA);
			
			string[] entryNamesB = {"Single"};
			Person entryObjectB = Person.OneName(2, entryNamesB);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(flagRes, 1);
		}
		
		[Test]
		public void FirstMiddleLast()
		{
			string[] entryNamesA = {"Jordan", "Alan", "Burns"};
			Person entryObjectA = Person.MoreNames(1, entryNamesA);
			
			string[] entryNamesB = {"Martin", "Septim"};
			Person entryObjectB = Person.TwoNames(2, entryNamesB);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(flagRes, -1);
		}
		
		
		[Test]
		public void SameLastName()
		{
			string[] entryNamesA = {"Maureen", "Thomas"};
			Person entryObjectA = Person.TwoNames(1, entryNamesA);
			
			string[] entryNamesB = {"Ellen", "Thomas"};
			Person entryObjectB = Person.TwoNames(2, entryNamesA);
			
			int flagRes = NameOrder.CompareEntries(entryObjectA, entryObjectB);
			Assert.AreEqual(flagRes, -1);
		}
		
		[Test]
		public void DuplicateNames()
		{
			Assert.Pass();
		}
    }
}