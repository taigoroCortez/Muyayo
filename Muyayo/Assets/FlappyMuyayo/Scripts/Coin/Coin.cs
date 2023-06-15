using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : BaseMovement
{
    public event Action EventCoin;
    public int pointCoin;
   

    protected override void Awake()
    {
        
        base.Awake();
    }
    private void Update()
    {
        BaseMove();
    }

    void DisableMovement()
    {
        speed = 0f;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var score = FindObjectOfType<Score>();
            score.AddScore(pointCoin);
        }
    }
}
