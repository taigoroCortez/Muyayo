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
    public Button buttonRestar;
    public Button buttonExitApp;
    #endregion

    #region PanelMenu
    [Header("PanelInGame")]
    public TMP_Text score;
    #endregion

    private void Awake()
    {
        PanelMenu();
        FindObjectOfType<PanelMenuButton>().playEvent += PanelInGame;
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
        buttonRestar.gameObject.SetActive(false);
        buttonExitApp.gameObject.SetActive(false);

        score.gameObject.SetActive(false);
    }

    void PanelGameOver()
    {
        titleGameOver.gameObject.SetActive(true);
        buttonRestar.gameObject.SetActive(true);
        buttonExitApp.gameObject.SetActive(true);

        score.gameObject.SetActive(false);

        titleMenu.gameObject.SetActive(false);
        buttonPlay.gameObject.SetActive(false);
        buttonNext.gameObject.SetActive(false);
        selectPlayer.gameObject.SetActive(false);

    }

    void PanelInGame()
    {
        score.gameObject.SetActive(true);

        titleMenu.gameObject.SetActive(false);
        buttonPlay.gameObject.SetActive(false);
        buttonNext.gameObject.SetActive(false);
        selectPlayer.gameObject.SetActive(false);

        titleGameOver.gameObject.SetActive(false);
        buttonRestar.gameObject.SetActive(false);
        buttonExitApp.gameObject.SetActive(false);
    }

    
}
