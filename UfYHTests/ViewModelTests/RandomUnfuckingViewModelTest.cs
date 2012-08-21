using Microsoft.VisualStudio.TestTools.UnitTesting;
using UfYH.Models;
using UfYH.ViewModels;

namespace UfYHTests.ViewModelTests
{
    [TestClass]
    public class RandomUnfuckingViewModelTest
    {
        private RandomUnfuckingViewModel _randomViewModel;

        [TestInitialize]
        public void SetUp()
        {
            var randomlist = new RandomListModel();
            randomlist.Tasks.Add(new Task() { Text = "Clean the house", Room = "Bathroom" });
            randomlist.Tasks.Add(new Task() { Text = "Clean the sink", Duration = 5 });
            _randomViewModel = new RandomUnfuckingViewModel(randomlist);
        }

        [TestMethod]
        public void TestGetChallenge()
        {
            _randomViewModel.GetNewChallenge();
            var actual = _randomViewModel.ChallengeText;
            Assert.IsTrue(actual.Length > 0);
        }

        [TestMethod]
        public void TestTimeChoiceList()
        {
            const int expected = 5;
            var actual = _randomViewModel.SelectedTimeChoice;
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void TestSerialization()
        //{
        //    var randomlist = new RandomListModel();
        //    randomlist.Tasks.Add(new Task() { Text = "Clean the house", Room = "Bathroom"});
        //    randomlist.Tasks.Add(new Task() { Text = "Clean the sink", Duration=5 });

        //    var serializer = new XmlSerializer(typeof(RandomListModel));
        //    TextWriter textWriter = new StreamWriter(@"C:\temp\tasks.xml");
        //    serializer.Serialize(textWriter, randomlist);
        //    textWriter.Close();
        //}

        //[TestMethod]
        //public void TestDeserialization()
        //{
        //    var serializer = new XmlSerializer(typeof(RandomListModel));
        //    var textStream = new FileStream(@"C:\temp\tasks.xml", FileMode.Open);
        //    var randomList = serializer.Deserialize(textStream) as RandomListModel;
        //    Assert.IsTrue(randomList.Tasks.Count > 0);
        //}
    }
}
