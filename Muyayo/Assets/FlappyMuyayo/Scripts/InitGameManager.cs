using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InitGameManager : MonoBehaviour
{
    public event Action PlayGame;
    private static InitGameManager instance;
    public static InitGameManager Instance => instance;

    public GameObject[] panelesInGame;
    int panelMenu = 2;
    int panelInGame = 1;
    int panelGameOver = 3;

    public GameObject goPlayer;


    public bool initGame;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        goPlayer = GameObject.FindGameObjectWithTag("Player");
        panelesInGame = GameObject.FindGameObjectsWithTag("PanelesInGame");

        foreach(GameObject paneles in panelesInGame)
        {
            paneles.SetActive(false);
        }
        PanelMEnu(true);
        
        initGame = false;
    }
    public void StarGame()
    {
        PanelMEnu(false);
        PanelInGame(true);
        initGame = true;

        //ejecuto el evento starGame
        PlayGame?.Invoke();

        //goPlayer.transform.position = new Vector3(-1.5f, 0f, 0f);
        //goPlayer.transform.rotation = Quaternion.Euler(Vector3.zero);

    }

    void PanelGameOver()
    {

    }
    void PanelInGame(bool value)
    {
        panelesInGame[panelInGame].SetActive(value);
    }
    void PanelMEnu(bool value)
    {
        panelesInGame[panelMenu].SetActive(value);
    }
}
