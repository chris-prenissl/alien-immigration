using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using Booth.Timer;
using AlienImmigration.Audio;
using AlienImmigration.LifeCounter;
using Booth.Countertop;

namespace AlienImmigration
{
    public enum GameState
    {
        MainMenu,
        Credits,
        Starting,
        NewAlien,
        BoothTime,
        GameReset,
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
                    gameState = GameState.MainMenu;
                    StartCoroutine(Instance.GetComponent<AudioManager>().PlayMenuMusic());
                    Instance.menuCanvas.gameObject.SetActive(true);
                    Instance.creditsCanvas.gameObject.SetActive(false);
                    Instance.highscoreCanvas.gameObject.SetActive(false);
                    Instance.highscoreCanvasEndOfGame.gameObject.SetActive(false);
                    break;

                case (GameState.Credits):
                    gameState = GameState.Credits;
                    Instance.menuCanvas.gameObject.SetActive(false);
                    Instance.creditsCanvas.gameObject.SetActive(true);
                    break;

                case (GameState.Starting):
                    gameState = GameState.Starting;
                    Instance.menuCanvas.gameObject.SetActive(false);
                    StartCoroutine(Instance.GetComponent<AudioManager>().PlayBoothMusic());                    
                    break;

                case (GameState.NewAlien):  
                    gameState = GameState.NewAlien;
                    Instance.GetComponent<AlienSetup>().CreateAlien(1);
                    Instance.SwitchState(GameState.BoothTime);
                    break;

                case (GameState.BoothTime):
                    gameState = GameState.BoothTime;
                    Instance.GetComponent<TimerController>().ResetTimer();
                    Instance.GetComponent<TimerController>().StartTimer();
                    break;

                case (GameState.Highscore):
                    gameState = GameState.Highscore;
                    Instance.highscoreCanvas.gameObject.SetActive(true);
                    Instance.menuCanvas.gameObject.SetActive(false);
                    break;

                case (GameState.Ending):
                    gameState = GameState.Ending;
                    int finalScore = Instance.GetComponent<HighScoreHandler>().Score;
                    StartCoroutine(Instance.GetComponent<HighScoreHandler>().SubmitScoreRoutine(finalScore));
                    Instance.highscoreCanvasEndOfGame.gameObject.SetActive(true);
                    break;

                case (GameState.GameReset):
                    gameState = GameState.GameReset;
                    Instance.GetComponent<HighScoreHandler>().Score = 0;
                    Instance.GetComponent<LifeHandler>().Lives = 5;
                    Instance.GetComponent<LifeHandler>().LostLife();
                    Instance.GetComponent<PlayerNoteHandler>().NewGame = true;
                    Instance.GetComponent<CountertopHandler>().CloseAllTabs();
                    Instance.SwitchState(GameState.MainMenu);
                    break;

                case (GameState.Quit):
                    gameState = GameState.Quit;
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
            Application.targetFrameRate = 60;
        }

        #endregion


    }
}
