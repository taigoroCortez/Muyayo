using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSelectPlayer : MonoBehaviour
{
    private static ManagerSelectPlayer instance;
    public static ManagerSelectPlayer Instance => instance;
    

    [SerializeField] private int NumberPlayers = 3;
    public int player;

    private void Awake()
    {
        FindObjectOfType<PanelMenuButton>().nextEvent += ChangePlayerSkin;

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        player = 1;
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

 
}
