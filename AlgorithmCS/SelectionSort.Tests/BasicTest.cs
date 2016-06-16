using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectionSort;

namespace SelectionSort.Tests
{
    [TestClass]
    public class BasicTest
    {
        private Selection.SelectionSort sorter;

        [TestInitialize]
        public void Setup()
        {
            sorter = new Selection.SelectionSort();
        }

        [TestMethod]
        public void ShouldSortNonsortInteger()
        {
            int[] data = {3, 1, 2};
            sorter.Sort(data);

            Assert.AreEqual(1,data[0]);
            Assert.AreEqual(2, data[1]);
            Assert.AreEqual(3, data[2]);
        }

        [TestMethod]
        public void ShouldSortAscSortedInteger()
        {
            int[] data = { 1, 2, 3 };
            sorter.Sort(data);

            Assert.AreEqual(1, data[0]);
            Assert.AreEqual(2, data[1]);
            Assert.AreEqual(3, data[2]);
        }

        [TestMethod]
        public void ShouldSortDescSortedInteger()
        {
            int[] data = { 3, 2, 1 };
            sorter.Sort(data);

            Assert.AreEqual(1, data[0]);
            Assert.AreEqual(2, data[1]);
            Assert.AreEqual(3, data[2]);
        }

        [TestMethod]
        public void Should_return_empty_array()
        {
            int[] data = { };
            sorter.Sort(data);

            Assert.AreEqual(0,data.Length);
        }

        [TestMethod]
        public void Should_sort_one_element_array()
        {
            int[] data = { 1 };
            sorter.Sort(data);

            Assert.AreEqual(1, data.Length);
        }

    }
}
