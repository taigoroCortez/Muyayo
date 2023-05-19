using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeadPlayer : MonoBehaviour
{
    public event Action DeadGroundPlayer;
    public event Action DiePlayer;

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
}
