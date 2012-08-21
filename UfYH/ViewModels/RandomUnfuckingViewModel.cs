using System.Collections.Generic;
using Caliburn.Micro;
using UfYH.Models;

namespace UfYH.ViewModels
{
    public class RandomUnfuckingViewModel : Screen
    {
        public RandomUnfuckingViewModel(RandomListModel randomListModel)
        {
            ChallengeText = string.Empty;
            TimeChoice = new List<int> {5, 10, 20};
            SelectedTimeChoice = TimeChoice[0];
            RoomChoice = new List<string> {"All Rooms", "Bathroom", "Bedroom", "Kitchen", "Living Room"};
            SelectedRoomChoice = RoomChoice[0];
            Model = randomListModel;
        }

        public RandomListModel Model { get; set; }

        public string ChallengeText { get; set; }

        public void GetNewChallenge()
        {
            var roomIndex = RoomChoice.IndexOf(SelectedRoomChoice);
            var randomTask = Model.GetRandomTask(SelectedTimeChoice, (Room)roomIndex);

            ChallengeText = randomTask.Text;
            NotifyOfPropertyChange(() => ChallengeText);
        }

        public IList<int> TimeChoice { get; set; }
        public int SelectedTimeChoice { get; set; }

        public IList<string> RoomChoice { get; set; }
        public string SelectedRoomChoice { get; set; }
    }
}