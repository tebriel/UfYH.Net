using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UfYH.Models;

namespace UfYHTests.ModelTests
{
    [TestClass]
    public class RandomListModelTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            var randomlist = new RandomListModel();
            randomlist.Items.Add("Clean the house");
            randomlist.Items.Add("Clean the sink");
            randomlist.TimeLength = 5;
            Assert.AreEqual(2, randomlist.Items.Count);
            Assert.AreEqual(5, randomlist.TimeLength);
        }
    }
}
