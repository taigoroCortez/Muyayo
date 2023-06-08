 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeadPlayer : MonoBehaviour
{
    public AudioEvent Coin;
    public AudioSource audio;
    public event Action DeadGroundPlayer;
    public event Action DiePlayer;
    public event Action collisionCoin;

    PlayerController playerController;
    CameraShake cameraShake;
    private void Awake()
    {
        
        cameraShake = FindObjectOfType<CameraShake>();
        playerController = GetComponent<PlayerController>();

        FindObjectOfType<DeadZoneSky>().CollisionPlayer += DeadSky;
        FindObjectOfType<DeadZone>().CollisionPlayer += DeadGround;
    }
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            DeadSky();
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            CollisionCoins();
            collision.gameObject.SetActive(false);
            Coin.Play(audio);
        }
        
    }

 

    void CollisionCoins()
    {
        collisionCoin?.Invoke();
    }
    public void DeadSky()
    {
        Dead();
    }

    public void DeadGround()
    {
        Dead();
        DeadGroundPlayer?.Invoke();
    }

    void Dead()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
        playerController.enabled = false;
        DiePlayer?.Invoke();
    }

    private void OnDisable()
    {
        
    }
}
