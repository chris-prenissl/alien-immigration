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
        Ending,
        Quit,
    }

    public class GameManager : MonoBehaviour
    {
        #region Fields
        public static GameManager Instance;

        [SerializeField] private Canvas menuCanvas;
        [SerializeField] private Canvas creditsCanvas;
        [SerializeField] private Canvas highscoreCanvas;
        [SerializeField] private Canvas highscoreCanvasEndOfGame;

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
                    Instance.menuCanvas.gameObject.SetActive(true);
                    Instance.creditsCanvas.gameObject.SetActive(false);
                    Instance.highscoreCanvas.gameObject.SetActive(false);
                    break;

                case (GameState.Credits):
                    Instance.menuCanvas.gameObject.SetActive(false);
                    Instance.creditsCanvas.gameObject.SetActive(true);
                    break;

                case (GameState.Starting):
                    Instance.menuCanvas.gameObject.SetActive(false);
                    break;

                case (GameState.NewAlien):
                    break;

                case (GameState.BoothTime):
                    break;

                case (GameState.Highscore):
                    Instance.highscoreCanvas.gameObject.SetActive(true);
                    Instance.menuCanvas.gameObject.SetActive(false);
                    break;

                case (GameState.Ending):
                    Instance.highscoreCanvasEndOfGame.gameObject.SetActive(true);
                    break;

                case (GameState.Quit):
                    Application.Quit();
#if UNITY_EDITOR
                    EditorApplication.ExitPlaymode();
#endif
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

            Instance.SwitchState(GameState.MainMenu);
        }

        #endregion


    }
}
