using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIMenuManager : MonoBehaviour
{
    public RectTransform mainMenu, selectGame, setting, credits;
    float timeAnimation = 0.25f;
    [SerializeField] private AudioSource audioSource;
    public AudioEvent audioEvent;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToPortrait = true;

        mainMenu.DOAnchorPos(Vector2.zero, 0.25f);

    }

    #region ButtonMainMenu
    public void ButtonSelectGame()
    {
        mainMenu.DOAnchorPos(new Vector2(-2000,0), timeAnimation);
        selectGame.DOAnchorPos(new Vector2(0, 0), timeAnimation);
        audioEvent.Play(audioSource);
    }

    public void ButtonBackSelectGame()
    {
        mainMenu.DOAnchorPos(new Vector2(0,0), timeAnimation);
        selectGame.DOAnchorPos(new Vector2(2000,0), timeAnimation);
        audioEvent.Play(audioSource);
    }

    public void ButtonSetting()
    {
        mainMenu.DOAnchorPos(new Vector2(-2000, 0), timeAnimation);
        setting.DOAnchorPos(new Vector2(0, 0), timeAnimation);
        audioEvent.Play(audioSource);
    }

    public void ButtonBackSetting()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), timeAnimation);
        setting.DOAnchorPos(new Vector2(0, 4200), timeAnimation);
        audioEvent.Play(audioSource);
    }

    public void ButtonCredits()
    {
        mainMenu.DOAnchorPos(new Vector2(-2000, 0), timeAnimation);
        credits.DOAnchorPos(new Vector2(0, 0), timeAnimation);
        audioEvent.Play(audioSource);
    }

    public void ButtonBackCredits()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 0), timeAnimation);
        credits.DOAnchorPos(new Vector2(0, -3550), timeAnimation);
        audioEvent.Play(audioSource);
    }
    #endregion
}
