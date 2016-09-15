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
            /*string s1 = MakeString(arr1);
            string s2 = MakeString(arr2);
            Assert.AreEqual(s2, s1, null, "Sort failed");*/
            CollectionAssert.AreEqual(arr2, arr1);
        }

        [TestMethod]
        public void TestSortNull()
        {
            int[] arr1 = null;
            MyQuickSort.QuickSort<int>(arr1, 0, 0);
            Assert.IsNull(arr1);
        }

        public string MakeString<T>(T[] arr)
        {
            string s1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                s1 += arr[i].ToString() + ' ';
            }
            return s1;
        }

        [TestMethod]
        public void TestSortEqual()
        {
            int[] arr = { 1, 1, 1, 1, 1 };
            MyQuickSort.QuickSort<int>(arr, 0, arr.Length - 1);
            string s1 = MakeString(arr);
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
        [TestMethod]
        public void TestSortReversed()
        {
            int[] arr = { 10, 9, 8, 7, 6 };
            MyQuickSort.QuickSort<int>(arr, 0, arr.Length - 1);
            string s1 = MakeString(arr);
            Assert.AreEqual("6 7 8 9 10 ", s1, null, "Sort failed");
        }
        [TestMethod]
        public void TestSortString()
        {
            string[] sarr = { "zero", "batman", "69", "sponge bob", "squere paints", "iron maiden" };
            MyQuickSort.QuickSort<string>(sarr, 0, sarr.Length - 1);
            string s1 = MakeString<string>(sarr);
            Assert.AreEqual("69 batman iron maiden sponge bob squere paints zero ", s1, null, "Sort failed");
        }

    }
}
