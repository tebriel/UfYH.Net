using System;

namespace UfYH.ViewModels
{
    using Caliburn.Micro;

    public class ShellViewModel: PropertyChangedBase
    {

        private readonly Func<IScreen> _getRandomUnfuckingChallenge;

        public ShellViewModel(Func<IScreen> getRandomUnfuckingChallenge)
        {
            _getRandomUnfuckingChallenge = getRandomUnfuckingChallenge;
            ContentPanel = _getRandomUnfuckingChallenge();
        }

        public IScreen ContentPanel { get; set; }

    }
}