using UnityEngine;
using System;


public class DeadZoneSky : MonoBehaviour
{
    public event Action CollisionPlayer;

    private void Awake()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Muere el jugador arriba");
            CollisionPlayer?.Invoke();

        }
    }
    
}
