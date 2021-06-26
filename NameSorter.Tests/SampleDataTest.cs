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
		private string[] sortedNames = null;
		
		// Define, parse, and sort data.
		[SetUp]
		public void PrepareSampleData()
		{
			string[] txtLines = new string[11];
			List<Person> sampleEntries = new List<Person>();
			
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
			
			sampleEntries = ParseNames.IterateLines(txtLines);
			SortNames.PerformSort(sampleEntries);
			sortedNames = WriteOutputFile.PrepareLines(sampleEntries);
		}
		
		// Test correct order.
		[Test]
		public void TestSortResults()
		{
			Assert.AreEqual("Marin Alvarez", sortedNames[0]);
			Assert.AreEqual("Adonis Julius Archer", sortedNames[1]);
			Assert.AreEqual("Beau Tristan Bentley", sortedNames[2]);
			Assert.AreEqual("Hunter Uriah Mathew Clarke", sortedNames[3]);
			Assert.AreEqual("Leo Gardner", sortedNames[4]);
			Assert.AreEqual("Vaughn Lewis", sortedNames[5]);
			Assert.AreEqual("London Lindsey", sortedNames[6]);
			Assert.AreEqual("Mikayla Lopez", sortedNames[7]);
			Assert.AreEqual("Janet Parsons", sortedNames[8]);
			Assert.AreEqual("Frankie Conner Ritte", sortedNames[9]);
			Assert.AreEqual("Shelby Nathan Yoder", sortedNames[10]);
		}
    }
}