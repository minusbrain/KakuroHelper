using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KakuroHelper;
using System.Collections.Generic;

namespace KakuroTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_Sum1_CorrectNumOfListsCorrectListSizeCorrectValues()
        {
            KakuroBase dut = new KakuroBase(1, 9);

            List<List<int>> lists = dut.getPossibleCombinationsForSum(1, 1, null, null);

            Assert.AreEqual(1, lists.Count);
            Assert.AreEqual(1, lists[0].Count);
            Assert.AreEqual(1, lists[0][0]);
        }
        [TestMethod]
        public void test_Sum2_CorrectNumOfListsCorrectListSizeCorrectValues()
        {
            KakuroBase dut = new KakuroBase(1, 9);

            List<List<int>> lists = dut.getPossibleCombinationsForSum(2, 1, null, null);

            Assert.AreEqual(1, lists.Count);
            Assert.AreEqual(1, lists[0].Count);
            Assert.AreEqual(2, lists[0][0]);
        }

        [TestMethod]
        public void test_Sum3Size1_CorrectNumOfListsCorrectListSizeCorrectValues()
        {
            KakuroBase dut = new KakuroBase(1, 9);

            List<List<int>> lists = dut.getPossibleCombinationsForSum(3, 1, null, null);

            Assert.AreEqual(1, lists.Count);
            Assert.AreEqual(1, lists[0].Count);
            Assert.AreEqual(3, lists[0][0]);
        }

        [TestMethod]
        public void test_Sum3Size2_CorrectNumOfListsCorrectListSizeCorrectValues()
        {
            KakuroBase dut = new KakuroBase(1, 9);

            List<List<int>> lists = dut.getPossibleCombinationsForSum(3, 2, null, null);

            Assert.AreEqual(1, lists.Count);
            Assert.AreEqual(2, lists[0].Count);
            Assert.AreEqual(1, lists[0][0]);
            Assert.AreEqual(2, lists[0][1]);
        }
    }
}
