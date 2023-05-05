using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayerInGame : MonoBehaviour
{
    public ManagerSelectPlayer managerSelectPlayer;
    public GameObject[] playerInGame;
    // Start is called before the first frame update
    void Start()
    {
        managerSelectPlayer = GameObject.FindGameObjectWithTag("ManagerSelectPlayer").GetComponent<ManagerSelectPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (managerSelectPlayer.player == 1)
        {
            playerInGame[0].SetActive(true);
            playerInGame[1].SetActive(false);
            playerInGame[2].SetActive(false);
        }
        else if(managerSelectPlayer.player == 2)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(true);
            playerInGame[2].SetActive(false);
        }
        else if(managerSelectPlayer.player == 3)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(false);
            playerInGame[2].SetActive(true);
        }
    }
}
