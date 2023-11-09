using CardMatchingGame.Presentation.Systems;
using UnityEngine;

namespace CardMatchingGame.Presentation
{
    public class PresentationSceneReferenceHolder : MonoBehaviour
    {
        internal static GridHandlerPresentation GridHandlerPresentation;
        internal static MatchingCardsSystem MatchingCardsSystem;
        internal static ScoreSystem ScoreSystem;
        internal static CardsListener CardsListener;

        [SerializeField] private GridHandlerPresentation _gridHandlerPresentation;
        [SerializeField] private MatchingCardsSystem _matchingCardsSystem;
        [SerializeField] private ScoreSystem _scoreSystem;
        [SerializeField] private CardsListener _cardsListener;

        private void Awake()
        {
            GridHandlerPresentation = _gridHandlerPresentation;
            MatchingCardsSystem = _matchingCardsSystem;
            ScoreSystem = _scoreSystem;
            CardsListener = _cardsListener;
        }
    }
}
