using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textHightScore;

    public int playerScore;
    public int hightScore;

    public AudioEvent siuuu;
    public AudioSource audio;

    public event Action tornado;

    RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        FindObjectOfType<PanelMenuButton>().playEvent += PositionPlay;
        audio = GetComponent<AudioSource>();
        
        FindObjectOfType<DeadPlayer>().DiePlayer += PositionGameOver;
    }
    void Start()
    {
        
        textScore = GetComponent<TextMeshProUGUI>();
        playerScore = 0;
        textHightScore.text = PlayerPrefs.GetInt("TextHightScore", 0).ToString();

        
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddScore(int InputPoint)
    {
        playerScore += InputPoint;
        textScore.text = playerScore.ToString("0");
        if (playerScore >= 1000)
        {
            ActivateSiu();   
        }
        else if(playerScore >= 2000)
        {
            ActivateSiu();
        }
        else if (playerScore >= 3000)
        {
            ActivateSiu();
        }
        else if (playerScore >= 4000)
        {
            ActivateSiu();
        }
        else if (playerScore >= 5000)
        {
            ActivateSiu();
        }
        else if (playerScore >= 6000)
        {
            ActivateSiu();
        }
        else if (playerScore >= 7000)
        {
            ActivateSiu();
        }


        if (playerScore > PlayerPrefs.GetInt("TextHightScore", 0))
        {
            PlayerPrefs.SetInt("TextHightScore", playerScore);
            textHightScore.text = playerScore.ToString();
        }
    }

    void ActivateSiu()
    {
        siuuu.Play(audio);
        StartCoroutine(DisableSiu());
    }
    void PositionPlay()
    {
        rectTransform.anchoredPosition = new Vector2(-10, -33);
    }
    void PositionGameOver()
    {
        rectTransform.anchoredPosition = new Vector2(-350,-1008);
    }
    IEnumerator DisableSiu()
    {
        yield return new WaitForSeconds(2f);
        audio.enabled = false;
    }
}
