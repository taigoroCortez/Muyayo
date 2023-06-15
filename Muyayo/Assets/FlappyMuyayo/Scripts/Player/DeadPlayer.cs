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
   
    Rigidbody2D rb;

    PlayerController playerController;
    CameraShake cameraShake;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cameraShake = FindObjectOfType<CameraShake>();
        playerController = GetComponent<PlayerController>();
       
        FindObjectOfType<DeadZoneSky>().DieZoneSky += DeadSky;
        FindObjectOfType<DeadZoneGround>().DieZoneGround += DeadGround;
    }
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            DeadByEnemy();
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.GetComponent<IScoreCoin>()?.Score();
         
            collision.gameObject.SetActive(false);
            Coin.Play(audio);
        }
        
    }

 

   
    public void DeadSky()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
        var groundZone = FindObjectOfType<DeadZoneGround>();
        groundZone.gameObject.SetActive(false);
        Dead();
    }

    public void DeadGround()
    {
        Dead();
        DeadGroundPlayer?.Invoke();
    }

    void DeadByEnemy()
    {
        Dead();
    }

    void Dead()
    {
        playerController.enabled = false;
        DiePlayer?.Invoke();
    }

}
