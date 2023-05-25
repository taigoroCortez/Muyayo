using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    int score;

    private void Awake()
    {
        FindObjectOfType<Coin>().collisionPlayer += AddScore;
    }
    void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddScore()
    {
        score += 1;
        textScore.text = score.ToString("0");
    }
}
