using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameManager : MonoBehaviour
{
    private static InitGameManager instance;
    public static InitGameManager Instance => instance;

    public GameObject panelMenu;
    public GameObject goPlayer;


    public GameObject[] test;
    private int numBG;

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
        test = GameObject.FindGameObjectsWithTag("Background");
        
       foreach(var go in test)
        {
            go.SetActive(false);
        }

        var indexRandom = Random.Range(0, test.Length);
        test[indexRandom].SetActive(true);

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
