using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSelectPlayer : MonoBehaviour
{
    
    

    [SerializeField] private int NumberPlayers = 3;
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
       
        
        
    }
}
