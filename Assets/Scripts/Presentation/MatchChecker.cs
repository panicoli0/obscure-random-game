using CardMatchingGame.UI;
using CardMatchingGame.UI.View;
using System.Collections.Generic;
using UnityEngine;

namespace CardMatchingGame.Presentation
{
    [DisallowMultipleComponent]
    public class MatchChecker : MonoBehaviour, IMatchGetter
    {
        public int WinLevelCont { get => winLevelCont; set => winLevelCont = value; }

        [SerializeField] private AudioSource _audioSource;

        private int winLevelCont = 0;

        public void CheckMatch(List<CardView> cards)
        {
            foreach (CardView card in cards)
            {
                if (card.CurrentState == CardView.State.Matched && card.isActiveAndEnabled)
                {
                    card.Matched();
                    PresentationSceneReferenceHolder.ScoreSystem.AddScore(card.value);
                    winLevelCont++;
                }
            }
            // Check win
            int size;
            size = PlayerPrefs.GetInt("GridSize");
            if (winLevelCont >= size)
            {
                Debug.Log("You win the level!");
                _audioSource.PlayOneShot(_audioSource.clip);
                UISceneReferenceHolder.EndLevelMenu.MenuToggle(true);
                CleanUpSecuence();
            }
        }

        public void CleanUpSecuence()
        {
            PresentationSceneReferenceHolder.CardsListener.Moves = 0;
            PresentationSceneReferenceHolder.GridHandlerPresentation.CleanGrid();
        }
    }
}
