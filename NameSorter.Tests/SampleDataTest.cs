using System.Collections.Generic;
using NUnit.Framework;
using NameSorter.Common;
using NameSorter.Tasks;

namespace NameSorter.Tests
{
    // Unit test for sample data provided in assessment description.
	
	[TestFixture]
	public class SampleDataTest
    {	
		private string[] _sortedNames;
		
		// Define, parse, and sort data.
		[SetUp]
		public void PrepareSampleData()
		{
			string[] txtLines = new string[11];

            txtLines[0] = "Janet Parsons";
			txtLines[1] = "Vaughn Lewis";
			txtLines[2] = "Adonis Julius Archer";
			txtLines[3] = "Shelby Nathan Yoder";
			txtLines[4] = "Marin Alvarez";
			txtLines[5] = "London Lindsey";
			txtLines[6] = "Beau Tristan Bentley";
			txtLines[7] = "Leo Gardner";
			txtLines[8] = "Hunter Uriah Mathew Clarke";
			txtLines[9] = "Mikayla Lopez";
			txtLines[10] = "Frankie Conner Ritte";

            List<Person> sampleEntries = ParseNames.IterateLines(txtLines);
			SortNames.PerformSort(sampleEntries, 1);
			_sortedNames = WriteOutputFile.PrepareLines(sampleEntries);
		}
		
		// Test correct order.
		[Test]
		public void TestSortResults()
		{
			Assert.AreEqual("Marin Alvarez", _sortedNames[0]);
			Assert.AreEqual("Adonis Julius Archer", _sortedNames[1]);
			Assert.AreEqual("Beau Tristan Bentley", _sortedNames[2]);
			Assert.AreEqual("Hunter Uriah Mathew Clarke", _sortedNames[3]);
			Assert.AreEqual("Leo Gardner", _sortedNames[4]);
			Assert.AreEqual("Vaughn Lewis", _sortedNames[5]);
			Assert.AreEqual("London Lindsey", _sortedNames[6]);
			Assert.AreEqual("Mikayla Lopez", _sortedNames[7]);
			Assert.AreEqual("Janet Parsons", _sortedNames[8]);
			Assert.AreEqual("Frankie Conner Ritte", _sortedNames[9]);
			Assert.AreEqual("Shelby Nathan Yoder", _sortedNames[10]);
		}
    }
}