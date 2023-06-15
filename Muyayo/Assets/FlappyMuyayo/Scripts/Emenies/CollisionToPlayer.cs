using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionToPlayer : MonoBehaviour
{
    public event Action rbDie;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rbDie?.Invoke();
        }
    }
}
