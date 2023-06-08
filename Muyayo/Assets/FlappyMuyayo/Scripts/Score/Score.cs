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
        FindObjectOfType<DeadPlayer>().collisionCoin += AddScore;
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
        score += 10;
        textScore.text = score.ToString("0");
    }
}
