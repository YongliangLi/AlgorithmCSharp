using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsertionSort.Tests
{
    [TestClass]
    public class InsertionTest
    {
        InsertionSorting sort = new InsertionSorting();

        [TestMethod]
        public void Should_Sort_array()
        {
            int[] data = { 6, 2, 3 };

            sort.Sort(data);

            Assert.AreEqual(data[0], 2);
            Assert.AreEqual(data[1], 3);
            Assert.AreEqual(data[2], 6);
        }
    }
}
