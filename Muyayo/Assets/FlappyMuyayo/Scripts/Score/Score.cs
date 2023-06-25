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

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
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
            siuuu.Play(audio);
            StartCoroutine(DisableSiu());
        }

        
        if (playerScore > PlayerPrefs.GetInt("TextHightScore", 0))
        {
            PlayerPrefs.SetInt("TextHightScore", playerScore);
            textHightScore.text = playerScore.ToString();
        }
    }

    IEnumerator DisableSiu()
    {
        yield return new WaitForSeconds(2f);
        audio.enabled = false;
    }
}
