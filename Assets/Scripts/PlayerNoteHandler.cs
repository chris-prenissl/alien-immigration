using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using AlienImmigration;

public class PlayerNoteHandler : MonoBehaviour
{
    #region Fields

    [SerializeField] private Image playerNote;

    #endregion

    #region Properties

    private bool newGame = true;

    public bool NewGame
    {
        get { return newGame; }
        set { newGame = value; }
    }


    #endregion

    #region Private Functions

    private void DisablePlayerNote()
    {
        playerNote.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && newGame && GameManager.Instance.GameState == GameState.Starting)
        {
            DisablePlayerNote();
            GameManager.Instance.SwitchState(GameState.NewAlien);
            newGame = false;
        }
    }


    #endregion


}
