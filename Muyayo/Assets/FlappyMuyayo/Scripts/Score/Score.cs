using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public int playerScore;


    private void Awake()
    {

    }
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        playerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int InputPoint)
    {
        playerScore += InputPoint;
        textScore.text = playerScore.ToString("0");
    }
}
