using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using AlienImmigration;

namespace MainMenu
{

    public class MenuButtonHandler : MonoBehaviour
    {

        #region Public Functions

        public void StartGame()
        {
            GameManager.Instance.SwitchState(GameState.Starting);
        }

        public void QuitGame()
        {
            GameManager.Instance.SwitchState(GameState.Ending);
        }

        public void GoToCredits()
        {
            GameManager.Instance.SwitchState(GameState.Credits);
        }

        public void GoToMainMenu()
        {
            GameManager.Instance.SwitchState(GameState.MainMenu);
        }

        #endregion
    }
}
