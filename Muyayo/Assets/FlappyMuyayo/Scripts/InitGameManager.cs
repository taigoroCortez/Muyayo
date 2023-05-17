using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InitGameManager : MonoBehaviour
{
    #region Singleton
    private static InitGameManager instance;
    public static InitGameManager Instance => instance;
    #endregion

    
    
    
    public bool initGame = false;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        FindObjectOfType<PanelMenuButton>().playEvent += StarGame;
    }

    private void Start()
    {
        initGame = false;
    }


    //aqui se ejecuta desde editor con el onclickeditor
    public void StarGame()
    {
        initGame = true;
        Debug.Log("InitGame " + initGame);
        
    }
    
   
}
