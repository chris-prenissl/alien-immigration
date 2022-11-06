using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using AlienImmigration;
using AlienImmigration.LifeCounter;

namespace Booth.Countertop
{
    public class CountertopHandler : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Button ruleBookSmall;
        [SerializeField] private Button ruleBookLarge;
        [SerializeField] private Button alienIDSmall;
        [SerializeField] private Button alienIDLarge;
        [SerializeField] private Button acceptButton;
        [SerializeField] private Button rejectButton;

        private bool _rejected;
        private bool _accepted;
        private bool _correctChoice;

        #endregion

        #region Properties



        #endregion

        #region Public Functions

        public void ZoomRuleBook()
        {
            ruleBookSmall.interactable = false;
            ruleBookLarge.gameObject.SetActive(true);
        }

        public void CloseLargeRuleBook()
        {
            ruleBookSmall.interactable = true;
            ruleBookLarge.gameObject.SetActive(false);
        }

        public void ZoomAlienID()
        {
            alienIDSmall.interactable = false;
            alienIDLarge.gameObject.SetActive(true);
        }

        public void CloseLargeAlienID()
        {
            alienIDSmall.interactable = true;
            alienIDLarge.gameObject.SetActive(false);
        }

        public void AcceptAlien()
        {
            _accepted = true;
            CheckForCorrectChoice();
        }

        public void RejectAlien()
        {
            _rejected = true;
            CheckForCorrectChoice();
        }
        #endregion

        #region Private Functions

        private void CheckForCorrectChoice()
        {
            if (_accepted)
            {

                bool canPass = GameManager.Instance.GetComponent<AlienManager>().alienSpawned.canPass;

                if (!canPass)
                {
                    _correctChoice = false;
                }
                //ToDo Request canPass
                //ToDo correctChoice -assign highscore increase
                if(!_correctChoice)
                {
                    LifeHandler _lifeHandler = GameManager.Instance.GetComponent<LifeHandler>();
                    _lifeHandler.LostLife();
                }
            }
            else if (_rejected)
            {
                //ToDo Request canPass
                //ToDo correctChoice -assign highscore increase
                if (!_correctChoice)
                {
                    LifeHandler _lifeHandler = GameManager.Instance.GetComponent<LifeHandler>();
                    _lifeHandler.LostLife();
                }
            }
            else
            {
                Debug.Log("Unextpected Button Behaviour!");
            }

            _accepted = false;
            _rejected = false;
        }

        #endregion
    }
}
