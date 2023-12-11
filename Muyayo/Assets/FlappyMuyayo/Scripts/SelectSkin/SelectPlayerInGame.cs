using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayerInGame : MonoBehaviour
{
    PlayerController playerController;
    public ManagerSelectPlayer managerSelectPlayer;
    public GameObject[] playerInGame;
    // Start is called before the first frame update

    private void Awake()
    {
        FindObjectOfType<PanelMenuButton>().playEvent += ActivePlayerController;
    }
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        playerController.enabled = false;

 
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
            playerInGame[3].SetActive(false);
            playerInGame[4].SetActive(false);
            playerInGame[5].SetActive(false);
            playerInGame[6].SetActive(false);
        }
        else if(managerSelectPlayer.player == 2)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(true);
            playerInGame[2].SetActive(false);
            playerInGame[3].SetActive(false);
            playerInGame[4].SetActive(false);
            playerInGame[5].SetActive(false);
            playerInGame[6].SetActive(false);
        }
        else if(managerSelectPlayer.player == 3)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(false);
            playerInGame[2].SetActive(true);
            playerInGame[3].SetActive(false);
            playerInGame[4].SetActive(false);
            playerInGame[5].SetActive(false);
            playerInGame[6].SetActive(false);
        }
        else if (managerSelectPlayer.player == 4)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(false);
            playerInGame[2].SetActive(false);
            playerInGame[3].SetActive(true);
            playerInGame[4].SetActive(false);
            playerInGame[5].SetActive(false);
            playerInGame[6].SetActive(false);
        }
        else if (managerSelectPlayer.player == 5)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(false);
            playerInGame[2].SetActive(false);
            playerInGame[3].SetActive(false);
            playerInGame[4].SetActive(true);
            playerInGame[5].SetActive(false);
            playerInGame[6].SetActive(false);
        }
        else if (managerSelectPlayer.player == 6)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(false);
            playerInGame[2].SetActive(false);
            playerInGame[3].SetActive(false);
            playerInGame[4].SetActive(false);
            playerInGame[5].SetActive(true);
            playerInGame[6].SetActive(false);
        }
        else if (managerSelectPlayer.player == 7)
        {
            playerInGame[0].SetActive(false);
            playerInGame[1].SetActive(false);
            playerInGame[2].SetActive(false);
            playerInGame[3].SetActive(false);
            playerInGame[4].SetActive(false);
            playerInGame[5].SetActive(false);
            playerInGame[6].SetActive(true);
        }
    }

    void ActivePlayerController()
    {
        playerController.enabled = true;
    }
}
