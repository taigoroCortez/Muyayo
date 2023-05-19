
using UnityEngine;
using System;

public class DeadZone : MonoBehaviour
{
    public event Action CollisionPlayer;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BoxCollider2D box = GetComponent<BoxCollider2D>();
            box.isTrigger = false;
            CollisionPlayer?.Invoke();
        }
    }
}
