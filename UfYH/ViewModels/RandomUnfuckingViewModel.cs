using Caliburn.Micro;

namespace UfYH.ViewModels
{
    public class RandomUnfuckingViewModel : Screen
    {
        public RandomUnfuckingViewModel()
        {
            ChallengeText = string.Empty;
        }

        public string ChallengeText { get; set; }

        public void GetNewChallenge()
        {
            ChallengeText = "Clean something!";
            NotifyOfPropertyChange(() => ChallengeText);
        }
    }
}