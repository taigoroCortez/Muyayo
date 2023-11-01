using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSelectPlayer : MonoBehaviour
{
    private static ManagerSelectPlayer instance;
    public static ManagerSelectPlayer Instance => instance;
    

    
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

    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;
    }

    public void ChangePlayerSkin()
    {
        if(player < 5)
        {
            player++;
        }
        else if(player == 5)
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
