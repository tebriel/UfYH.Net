using System;
using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using UfYH.Models;

namespace UfYH.ViewModels
{
    public class RandomUnfuckingViewModel : Screen
    {
        public RandomUnfuckingViewModel()
        {
            ChallengeText = string.Empty;
            TimeChoice = new List<int> {5, 10, 20};
            SelectedTimeChoice = TimeChoice[0];
            Lists = new List<RandomListModel>();
            var rlm = new RandomListModel();
            rlm.Items.Add("Clean the house");
            rlm.Items.Add("Clean the sink");
            rlm.TimeLength = TimeChoice[0];
            Lists.Add(rlm);
        }

        public IList<RandomListModel> Lists;

        public string ChallengeText { get; set; }

        public void GetNewChallenge()
        {
            var list = Lists.First(itemList => (itemList.TimeLength == SelectedTimeChoice));
            ChallengeText = list.Items[(new Random()).Next(0, Lists[0].Items.Count) ];
            NotifyOfPropertyChange(() => ChallengeText);
        }

        public IList<int> TimeChoice { get; set; }
        public int SelectedTimeChoice { get; set; }
    }
}