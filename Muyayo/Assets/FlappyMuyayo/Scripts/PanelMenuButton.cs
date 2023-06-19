using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelMenuButton : MonoBehaviour
{
    public GameObject musicMenu;
    public event Action playEvent;
    public event Action nextEvent;
    public event Action restarEvent;

    public Button buttonPlay;
    public Button buttonNext;
    public Button buttonrestar;

    public AudioEvent tapbutton;
    public AudioSource audio;

    private void Awake()
    {
        
        
    }
    void Start()
    {
        buttonPlay.onClick.AddListener(OnPlayButtonPress);
        buttonNext.onClick.AddListener(OnNextButtonPress);
        buttonrestar.onClick.AddListener(OnRestarButtonPress);
    }

    private void OnRestarButtonPress()
    {
        restarEvent?.Invoke();
    }
    private void OnPlayButtonPress()
    {
        tapbutton.Play(audio);
        playEvent?.Invoke();
        musicMenu.SetActive(false);
    }

    private void OnNextButtonPress()
    {
        tapbutton.Play(audio);
        nextEvent?.Invoke();
    }
}
