using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSelectPlayer : MonoBehaviour
{
    [SerializeField] private GameObject goPlayer;
    private Transform goPlayerTransform;
    [SerializeField] private GameObject panelMenu;
    [SerializeField] private int NumberPlayers = 3;
    public int player;
    // Start is called before the first frame update
    void Start()
    {
        goPlayer = GameObject.Find("Player");
        goPlayerTransform = goPlayer.GetComponent<Transform>();
        if (goPlayer == null) Debug.Log("null Player");

        panelMenu = GameObject.FindGameObjectWithTag("PanelMenu");
        DontDestroyOnLoad(this.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePlayerSkin()
    {
        if(player < NumberPlayers)
        {
            player++;
        }
        else if(player == NumberPlayers)
        {
            player = 1;
        }
        SaveData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("datos", JsonUtility.ToJson(this));
    }

    public void LoadData()
    {
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString("datos"), this);
    }

    public void StartGame()
    {
        panelMenu.gameObject.SetActive(false);
        goPlayer.transform.position = new Vector3(-1.5f, 0f, 0f);
        goPlayer.transform.rotation = Quaternion.Euler(Vector3.zero);
    }
}
