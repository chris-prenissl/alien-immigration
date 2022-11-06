using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using AlienImmigration;

public class PlayerNoteHandler : MonoBehaviour
{
    #region Fields

    [SerializeField] private Button playerNote;

    #endregion

    #region Private Functions

    private void DisablePlayerNote()
    {
        playerNote.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DisablePlayerNote();
            GameManager.Instance.SwitchState(GameState.NewAlien);
        }
    }


    #endregion


}
