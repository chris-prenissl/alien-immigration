using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using UnityEditor.UI;


namespace AlienImmigration
{
    public enum GameState
    {
        MainMenu,
        Credits,
        Starting,
        NewAlien,
        BoothTime,
        DecisionCheck,
        Highscore,
        Ending
    }

    public class GameManager : MonoBehaviour
    {
        #region Fields
        public static GameManager Instance;

        private Canvas menuCanvas;
        private Canvas creditsCanvas;

        #endregion

        #region Properties
        private GameState gameState;

        public GameState GameState
        {
            get { return gameState; }
            private set { gameState = value; }
        }

        private int highscore;

        public int Highscore
        {
            get { return highscore; }
            set { highscore = value; }
        }

        #endregion

        #region Public Functions

        public void SwitchState(GameState state)
        {
            switch (state)
            {
                case (GameState.MainMenu):
                    menuCanvas.gameObject.SetActive(true);
                    creditsCanvas.gameObject.SetActive(false);
                    break;

                case (GameState.Credits):
                    menuCanvas.gameObject.SetActive(false);
                    creditsCanvas.gameObject.SetActive(true);
                    break;

                case (GameState.Starting):
                    menuCanvas.gameObject.SetActive(false);
                    break;

                case (GameState.NewAlien):
                    break;

                case (GameState.BoothTime):
                    break;

                case (GameState.Highscore):
                    break;

                case (GameState.Ending):
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region Private Functions

        private void Start()
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            SwitchState(GameState.MainMenu);
        }

        #endregion


    }
}
