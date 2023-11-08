using CardMatchingGame.UI.View;
using UnityEngine;

namespace CardMatchingGame.UI
{
    public class UISceneReferenceHolder : MonoBehaviour
    {
        internal static MainMenuView MainMenuView;
        internal static GridSelectionMenuView GridSelectionMenuView;


        [SerializeField] private MainMenuView _mainMenuView;
        [SerializeField] private GridSelectionMenuView _gridSelectionMenuView;



        private void Awake()
        {
            MainMenuView = _mainMenuView;
            GridSelectionMenuView = _gridSelectionMenuView;
        }
    }
}
