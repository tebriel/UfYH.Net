using Microsoft.VisualStudio.TestTools.UnitTesting;
using UfYH.ViewModels;

namespace UfYHTests.ViewModelTests
{
    [TestClass]
    public class UnitTest1
    {
        private RandomUnfuckingViewModel _randomViewModel;

        [TestInitialize]
        public void SetUp()
        {
            _randomViewModel = new RandomUnfuckingViewModel();
        }

        [TestMethod]
        public void TestGetChallenge()
        {
            _randomViewModel.GetNewChallenge();
            const string expected = "Clean something!";
            var actual = _randomViewModel.ChallengeText;
            Assert.AreEqual(expected, actual);
        }
    }
}
