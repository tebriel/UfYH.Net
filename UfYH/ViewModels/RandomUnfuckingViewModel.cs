using System.Collections.Generic;
using Caliburn.Micro;

namespace UfYH.ViewModels
{
    public class RandomUnfuckingViewModel : Screen
    {
        public RandomUnfuckingViewModel()
        {
            ChallengeText = string.Empty;
            TimeChoice = new List<string>();
            TimeChoice.Add("5");
            TimeChoice.Add("20");
            TimeChoice.Add("45");
            SelectedTimeChoice = TimeChoice[0];
        }

        public string ChallengeText { get; set; }

        public void GetNewChallenge()
        {
            ChallengeText = "Clean something!";
            NotifyOfPropertyChange(() => ChallengeText);
        }

        public IList<string> TimeChoice { get; set; }
        public string SelectedTimeChoice { get; set; }
    }
}