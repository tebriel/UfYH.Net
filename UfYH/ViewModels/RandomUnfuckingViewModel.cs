using System;
using System.Collections.Generic;
using System.Linq;
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
            Model = randomListModel;
        }

        public RandomListModel Model { get; set; }

        public string ChallengeText { get; set; }

        public void GetNewChallenge()
        {
            var randomTask = Model.GetRandomTask(SelectedTimeChoice);
            ChallengeText = randomTask.Text;
            NotifyOfPropertyChange(() => ChallengeText);
        }

        public IList<int> TimeChoice { get; set; }
        public int SelectedTimeChoice { get; set; }
    }
}