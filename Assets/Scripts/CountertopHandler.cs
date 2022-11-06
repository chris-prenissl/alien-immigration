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

        [SerializeField] private Button alienIDSmall;
        [SerializeField] private Button alienIDLarge;
        [SerializeField] private Button acceptButton;
        [SerializeField] private Button rejectButton;

        [Header("Rule book")]
        [SerializeField] private Button ruleBookSmall;
        [SerializeField] private Button ruleBookLarge;
        [SerializeField] private Image ruleBookBackImage;

        [SerializeField] private Sprite rulesBookRulesTab;
        [SerializeField] private Sprite rulesBookDrociamiteTab;
        [SerializeField] private Sprite rulesBookBhucanderTab;
        [SerializeField] private Sprite rulesBookHuliphanTab;


        private bool _rejected;
        private bool _accepted;
        private bool _correctChoice;


        [SerializeField] private int addedScorePoints;
        #endregion

        #region Properties



        #endregion

        #region Public Functions

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

        //Rule book tabs

        public void ZoomRuleBook()
        {
            ruleBookSmall.interactable = false;
            ruleBookLarge.gameObject.SetActive(true);
            ruleBookBackImage.sprite = rulesBookRulesTab;
        }

        public void CloseLargeRuleBook()
        {
            ruleBookSmall.interactable = true;
            ruleBookLarge.gameObject.SetActive(false);
        }

        public void OpenDrociamiteTab()
        {
            ruleBookBackImage.sprite = rulesBookDrociamiteTab;
        }

        public void OpenBhucandereTab()
        {
            ruleBookBackImage.sprite = rulesBookBhucanderTab;
        }

        public void OpenHuliapianTab()
        {
            ruleBookBackImage.sprite = rulesBookHuliphanTab;
        }

        #endregion

        #region Private Functions

        private void CheckForCorrectChoice()
        {
            bool canPass = GameManager.Instance.GetComponent<AlienManager>().alienSpawned.canPass;

            if (_accepted)
            {
                if (!canPass)
                {
                    _correctChoice = false;
                }
                else
                {
                    _correctChoice = true;
                }

                if(!_correctChoice)
                {
                    LifeHandler _lifeHandler = GameManager.Instance.GetComponent<LifeHandler>();
                    _lifeHandler.LostLife();
                }

                GameManager.Instance.SwitchState(GameState.NewAlien);
            }
            else if (_rejected)
            {
                if(canPass)
                {
                    _correctChoice = false;

                }
                else
                {
                    _correctChoice= true;
                }

                if (!_correctChoice)
                {
                    LifeHandler _lifeHandler = GameManager.Instance.GetComponent<LifeHandler>();
                    _lifeHandler.LostLife();
                }

                GameManager.Instance.SwitchState(GameState.NewAlien);
            }
            else
            {
                Debug.Log("Unexpected Button Behaviour!");
            }

            switch (_correctChoice)
            {
                case true:
                    GameManager.Instance.GetComponent<HighScoreHandler>().Score += addedScorePoints;
                    break;

                case false:
                    break;
            }

            _correctChoice = false;
            _accepted = false;
            _rejected = false;
        }

        #endregion
    }
}
