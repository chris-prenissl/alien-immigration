using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        }

        public void RejectAlien()
        {

        }
        #endregion

        #region Private Functions



        #endregion
    }
}
