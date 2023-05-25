using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : MonoBehaviour
{
    public event Action collisionPlayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collisionPlayer?.Invoke();
            Debug.Log("coin + " + collision.gameObject.name);
        }
    }


}
