using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameManager : MonoBehaviour
{
    private static InitGameManager instance;
    public static InitGameManager Instance => instance;

    public GameObject panelMenu;
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
        panelMenu = GameObject.FindGameObjectWithTag("PanelMenu");
        goPlayer = GameObject.Find("Player");
   
        initGame = false;
    }
    public void StarGame()
    {
        panelMenu.gameObject.SetActive(false);
        initGame = true;
        goPlayer.transform.position = new Vector3(-1.5f, 0f, 0f);
        goPlayer.transform.rotation = Quaternion.Euler(Vector3.zero);

    }
}
