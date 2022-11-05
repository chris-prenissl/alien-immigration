using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace AlienImmigration
{
    public enum GameState
    {
        MainMenu,
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


        #endregion

        #region Properties
        private GameState gameState;

        public GameState GameState
        {
            get { return gameState; }
            private set { gameState = value; }
        }

        #endregion

        #region Public Functions

        public void SwitchState(GameState state)
        {
            switch (state)
            {
                case (GameState.MainMenu):
                    break;

                case (GameState.Starting):
                    break;

                case (GameState.NewAlien):
                    break;

                case (GameState.BoothTime):
                    break;

                case (GameState.Highscore):
                    break;

                case (GameState.Ending):
                    break;        
            }
        }


        #endregion 


    }
}
