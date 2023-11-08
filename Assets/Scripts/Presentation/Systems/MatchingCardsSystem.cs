using CardMatchingGame.UI.View;
using System.Collections.Generic;
using UnityEngine;

namespace CardMatchingGame.Presentation.Systems
{
    [RequireComponent(typeof(MatchChecker))]
    public class MatchingCardsSystem : MonoBehaviour
    {
        private IMatchGetter matchGetter = null;

        public MatchChecker MatchChecker { get => (MatchChecker)matchGetter; set => matchGetter = value; }

        private void Awake()
        {
            if (!TryGetComponent(out matchGetter)) { return; }
        }

        internal void AddMatchedCards(CardView firstCard, CardView secondCard)
        {
            var matchedCards = new List<CardView>
            {
                firstCard,
                secondCard
            };
            matchGetter.CheckMatch(matchedCards);
        }
    }
}