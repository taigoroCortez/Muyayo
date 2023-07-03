using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIGameManager : MonoBehaviour
{
    #region PanelMenu
    [Header("PanelMenu")]
    public TMP_Text titleMenu;
    public Button buttonPlay;
    public Button buttonNext;
    public GameObject selectPlayer;
    #endregion

    #region PanelGameOver
    [Header("PanelGameOver")]
    public TMP_Text titleGameOver;
    public TMP_Text titleHightScore;
    public TMP_Text hightScore;
    public Button buttonExit;

    public TMP_Text textScore;
    
    #endregion

    #region PanelInGame
    [Header("PanelInGame")]
    public TMP_Text score;
    #endregion

    private void Awake()
    {
        PanelMenu();
        FindObjectOfType<PanelMenuButton>().playEvent += PanelInGame;
        FindObjectOfType<DeadPlayer>().DiePlayer += PanelGameOver;
        selectPlayer = GameObject.FindGameObjectWithTag("SelectPlayer");
        if (!selectPlayer)
        {
            Debug.Log("Missing");
        }
    }

    private void Start()
    {
        
    }

    void PanelMenu()
    {
        titleMenu.gameObject.SetActive(true);
        buttonPlay.gameObject.SetActive(true);
        buttonNext.gameObject.SetActive(true);
        selectPlayer.gameObject.SetActive(true);

        titleGameOver.gameObject.SetActive(false);
        buttonExit.gameObject.SetActive(true);

        textScore.gameObject.SetActive(false);
        //buttonRestar.gameObject.SetActive(false);
        

        score.gameObject.SetActive(true);
        titleHightScore.gameObject.SetActive(false);
        hightScore.gameObject.SetActive(false);
    }

    void PanelGameOver()
    {
        titleGameOver.gameObject.SetActive(true);
        //buttonRestar.gameObject.SetActive(true);
       

        score.gameObject.SetActive(true);
        titleHightScore.gameObject.SetActive(true);
        hightScore.gameObject.SetActive(true);

        titleMenu.gameObject.SetActive(false);
        buttonPlay.gameObject.SetActive(false);
        buttonNext.gameObject.SetActive(false);
        selectPlayer.gameObject.SetActive(false);

        buttonExit.gameObject.SetActive(false);

        textScore.gameObject.SetActive(true);
    }

    void PanelInGame()
    {
        score.gameObject.SetActive(true);

        titleMenu.gameObject.SetActive(false);
        buttonPlay.gameObject.SetActive(false);
        buttonNext.gameObject.SetActive(false);
        selectPlayer.gameObject.SetActive(false);

        titleGameOver.gameObject.SetActive(false);
        //buttonRestar.gameObject.SetActive(false);
       
        hightScore.gameObject.SetActive(false);
        titleHightScore.gameObject.SetActive(false);

        buttonExit.gameObject.SetActive(false);
    }

    
}
