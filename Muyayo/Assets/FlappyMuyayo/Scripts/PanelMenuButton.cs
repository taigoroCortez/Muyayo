using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelMenuButton : MonoBehaviour
{
    public event Action playEvent;
    public event Action nextEvent;

    public Button buttonPlay;
    public Button buttonNext;

    private void Awake()
    {
        
        
    }
    void Start()
    {
        buttonPlay.onClick.AddListener(OnPlayButtonPress);
        buttonNext.onClick.AddListener(OnNextButtonPress);
    }

    private void OnPlayButtonPress()
    {
        Debug.Log("Press Button Play");
        playEvent?.Invoke();
    }

    private void OnNextButtonPress()
    {
        Debug.Log("Press Button NExt");
        nextEvent?.Invoke();
    }
}
