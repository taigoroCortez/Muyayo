using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSelectPlayer : MonoBehaviour
{
    public int player;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePlayerSkin()
    {
        if(player < 2)
        {
            player++;
        }
        else if(player == 2)
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
