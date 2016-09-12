using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;
namespace SortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSort()
        {
            string s1 = "";
            string s2 = "";
            int count = 10;
            int[] arr1 = new int[count];
            int[] arr2 = new int[count];
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                arr1[i] = rand.Next(100);
                arr2[i] = arr1[i];
            }
            MyQuickSort.QuickSort<int>(arr1, 0, arr1.Length - 1);
            Array.Sort<int>(arr2);
            for (int i = 0; i < count; i++)
            {
                s1 += arr1[i].ToString() + ' ';
                s2 += arr2[i].ToString() + ' ';
            }
            Assert.AreEqual(s2, s1, null, "Sort failed");
        }

        [TestMethod]
        public void TestSortNull()
        {
            int[] arr1 = null;
            MyQuickSort.QuickSort<int>(arr1, 0, 0);
            Assert.IsNull(arr1);
        }

        [TestMethod]
        public void TestSortEqual()
        {
            int[] arr = { 1, 1, 1, 1, 1 };
            string s1 = "";
            MyQuickSort.QuickSort<int>(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                s1 += arr[i].ToString() + ' ';
            }
            Assert.AreEqual("1 1 1 1 1 ", s1, null, "Sort failed");
        }

        [TestMethod]
        public void TestSortZeroCount()
        {
            int[] arr1 = new int[0];
            int[] arr2 = new int[0];
            MyQuickSort.QuickSort<int>(arr1, 0, arr1.Length - 1);
            CollectionAssert.AreEqual(arr2, arr1);
        }
    }
}
