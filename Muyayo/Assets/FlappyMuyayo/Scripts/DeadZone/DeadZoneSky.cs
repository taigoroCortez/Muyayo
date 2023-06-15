using UnityEngine;
using System;


public class DeadZoneSky : MonoBehaviour
{
    public event Action DieZoneSky;

    private void Awake()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DieZoneSky?.Invoke();
            var f = FindObjectOfType<DeadZoneSky>();
            f.gameObject.SetActive(false);
        }
    }
    
}
