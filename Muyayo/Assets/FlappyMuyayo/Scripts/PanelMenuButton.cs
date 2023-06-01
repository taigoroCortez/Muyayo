using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelMenuButton : MonoBehaviour
{
    public event Action playEvent;
    public event Action nextEvent;
    public event Action restarEvent;

    public Button buttonPlay;
    public Button buttonNext;
    public Button buttonrestar;

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
        playEvent?.Invoke();
    }

    private void OnNextButtonPress()
    {
        nextEvent?.Invoke();
    }
}
