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
            randomlist.Tasks.Add(new Task() { Text = "Clean the house" });
            randomlist.Tasks.Add(new Task() { Text = "Clean the sink" });
            Assert.AreEqual(2, randomlist.Tasks.Count);
        }
    }
}
