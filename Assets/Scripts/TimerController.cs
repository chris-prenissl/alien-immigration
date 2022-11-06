using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using AlienImmigration;
using Booth.Countertop;


namespace Booth.Timer
{
    public class TimerController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private TextMeshProUGUI timer;
        [SerializeField] private int timerSeconds;
        private int timerSecondsReference;

        #endregion

        #region Properties


        #endregion

        #region Private Functions

        // Start is called before the first frame update
        void Start()
        {
            timerSecondsReference = timerSeconds;
        }

        #endregion

        #region Public Functions

        public void ResetTimer()
        {
            StopCoroutine(nameof(AlienTimer));
            timerSeconds = timerSecondsReference;
        }

        public void StartTimer()
        {
            StartCoroutine(nameof(AlienTimer));
        }

        #endregion

        #region IEnumerators

        private IEnumerator AlienTimer()
        {
            for (int i = timerSecondsReference; i >= 0; i--)
            {
                timerSeconds = i;
                timer.text = timerSeconds.ToString();
                yield return new WaitForSeconds(1);

                if (timerSeconds == 0)
                {
                    CountertopHandler handler = GameManager.Instance.GetComponent<CountertopHandler>();
                    handler.RejectAlien();
                    Debug.Log("Alien Rejected");
                }
            }
        }

        #endregion
    }
}
