using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VariousAlgorithms;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            Sorting p = new Sorting(10);
            int[] unsorted = new int[] { 10, 5, 3, 8, 13, 1 };

            int[] sorted = p.BubbleSort(unsorted, out p.name);

            Assert.AreEqual(1, sorted[0]);
            Assert.AreEqual(3, sorted[1]);
            Assert.AreEqual(5, sorted[2]);
            Assert.AreEqual(8, sorted[3]);
            Assert.AreEqual(10, sorted[4]);
            Assert.AreEqual(13, sorted[5]);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            Sorting p = new Sorting(10);
            int[] unsorted = new int[] { 10, 5, 3, 8, 13, 1 };

            int[] sorted = p.SelectionSort(unsorted, out p.name);

            Assert.AreEqual(1, sorted[0]);
            Assert.AreEqual(3, sorted[1]);
            Assert.AreEqual(5, sorted[2]);
            Assert.AreEqual(8, sorted[3]);
            Assert.AreEqual(10, sorted[4]);
            Assert.AreEqual(13, sorted[5]);
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            Sorting p = new Sorting(10);
            int[] unsorted = new int[] { 10, 5, 3, 8, 13, 1 };

            int[] sorted = p.InsertionSort(unsorted, out p.name);

            Assert.AreEqual(1, sorted[0]);
            Assert.AreEqual(3, sorted[1]);
            Assert.AreEqual(5, sorted[2]);
            Assert.AreEqual(8, sorted[3]);
            Assert.AreEqual(10, sorted[4]);
            Assert.AreEqual(13, sorted[5]);
        }

    }
}
