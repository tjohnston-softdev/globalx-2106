using NUnit.Framework;

namespace NameSorter.Tests
{
    [TestFixture]
	public class ExampleTest
    {
		[Test]
        public void TestOne()
        {
			int calcVal = 6 * 5;
			Assert.AreEqual(calcVal, 30);
        }
    }
}