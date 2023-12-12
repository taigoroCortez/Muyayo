using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine.SocialPlatforms;
using System;

public class PlayGameScore : MonoBehaviour
{
    Score score;

    public static PlayGameScore instance;
    static bool active = false;

    private void Awake()
    {
        score = FindObjectOfType<Score>();
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!active)
        {
            DontDestroyOnLoad(this);
            active = true;
        }
        else
        {
            Destroy(this);
        }
        
    }

    void Initialize()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
       // Debug.Log("PlayGamesInitialized");
        PlayGamesPlatform.Instance.Authenticate(SuccesCallBack);
    }

    public void SendScore()
    {
        PlayGamesPlatform.Instance.Authenticate(SuccesCallBack);
        Social.ReportScore(score.playerScore, "CgkIu4rg9pUeEAIQAQ", success => { });
    }

    public void DisplayBoard()
    {
        PlayGamesPlatform.Instance.Authenticate(SuccesCallBack);
        PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIu4rg9pUeEAIQAQ");
    }
 
    internal void SuccesCallBack(SignInStatus success)
    {
        if(success == SignInStatus.Success)
        {
            Debug.Log("Signined in player using play games successfully");
        }
        else if(success == SignInStatus.InternalError)
        {
            Debug.Log("There is internal error");
        }
        else
        {
            Debug.Log("Signid not successfull");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
