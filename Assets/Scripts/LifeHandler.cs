using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AlienImmigration;
using UnityEngine.UI;

namespace AlienImmigration.LifeCounter
{
    public class LifeHandler : MonoBehaviour
    {

        #region Fields
        [SerializeField] private Button _lifeOne;
        [SerializeField] private Button _lifeTwo;
        [SerializeField] private Button _lifeThree;
        [SerializeField] private Button _lifeFour;

        #endregion


        #region Properties

        private int _lives = 4;

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }


        #endregion

        #region Public Functions

        public void LostLife()
        {
            _lives--;

            switch (_lives)
            {
                case (4):
                    break;

                case (3):
                    _lifeFour.gameObject.SetActive(false);
                    break;

                case (2):
                    _lifeThree.gameObject.SetActive(false);
                    break;

                case (1):
                    _lifeTwo.gameObject.SetActive(false);
                    break;

                    case (0):
                    _lifeOne.gameObject.SetActive(false);
                    GameManager.Instance.SwitchState(GameState.Ending);
                    break;

                default:
                    break;
                      
            }
        }


        #endregion
    }
}
