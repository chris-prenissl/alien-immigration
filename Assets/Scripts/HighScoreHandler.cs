using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LootLocker.Requests;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class HighScoreHandler : MonoBehaviour
{
    #region Fields

    public Leaderboard leaderboard;

    //ID for lootlocker leaderboard stage - 8456, live - not set yet
    private int leaderboardID = 8456;

    //show Highscores in MainMenuHUD
    public TextMeshProUGUI playerNamesMainMenu;
    public TextMeshProUGUI playerScoresMainMenu;

    //show Highscores in EndOfGameHUD
    public TextMeshProUGUI playerNamesEndOfGame;
    public TextMeshProUGUI playerScoresEndOfGame;
    public TextMeshProUGUI currentPlayerScore; //Shows Score, even if not top 10

    //set PlayerName for lootlocker
    public TMP_InputField playerNameInputfield;

    #endregion

    #region Private Functions

    private void Start()
    {
        StartCoroutine(nameof(LoginRoutine));
    
    }

    #endregion

    #region Public Functions

    //function to set PlayerName for lootlocker
    public void SetPlayerName()
    {
        LootLockerSDKManager.SetPlayerName(playerNameInputfield.text, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Successfully set player name");
                StartCoroutine(FetchTopHighscoresRoutine());
            }
            else
            {
                Debug.Log("Could not set player name");
            }
        });
    }

    #endregion


    #region IEnumerators

    public IEnumerator SubmitScoreRoutine(int scoreToUpload)
    {
        bool done = false;
        string playerID = PlayerPrefs.GetString("PlayerID");
        LootLockerSDKManager.SubmitScore(playerID, scoreToUpload, leaderboardID, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Successfully uploaded score");
                done = true;
            }
            else
            {
                Debug.Log("Failed" + response.Error);
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);

    }

    private IEnumerator LoginRoutine()
    {
        bool done = false;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            Debug.Log(response.success);
            if (response.success)
            {
                Debug.Log("Player was logged in");
                PlayerPrefs.SetString("PlayerID", response.player_id.ToString());
                done = true;
            }
            else
            {
                Debug.Log("Could not start session");
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }

    //gets the names and highscores from lootlocker
    //also sets the textmeshpro components for MainMenuHUD and GameEndHUD
    public IEnumerator FetchTopHighscoresRoutine()
    {
        bool done = false;
        LootLockerSDKManager.GetScoreList(leaderboardID, 10, 0, (response) =>
        {
            if (response.success)
            {
                string tempPlayerNames = "Name\n";
                string tempPlayerScores = "Score\n";

                //makes an array with all highscores
                LootLockerLeaderboardMember[] members = response.items;

                for (int i = 0; i < members.Length; i++)
                {
                    tempPlayerNames += members[i].rank + ". ";
                    if (members[i].player.name != "")
                    {
                        tempPlayerNames += members[i].player.name;
                    }
                    else
                    {
                        tempPlayerNames += members[i].player.id;
                    }
                    tempPlayerScores += members[i].score + "\n";
                    tempPlayerNames += "\n";
                }
                done = true;
                playerNamesMainMenu.text = tempPlayerNames;
                playerScoresMainMenu.text = tempPlayerScores;
                playerNamesEndOfGame.text = tempPlayerNames;
                playerScoresEndOfGame.text = tempPlayerScores;
            }
            else
            {
                Debug.Log("Failed" + response.Error);
                done = true;
            }
        });
        //waits for server communication
        yield return new WaitWhile(() => done == false);
    }

    #endregion
}
