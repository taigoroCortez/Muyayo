using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] private float superSpeedEnemies = 4f;
    [SerializeField] protected float speed = 3f;
    [SerializeField] protected float currentSpeed;

    protected virtual void Awake()
    {
        FindObjectOfType<DeadPlayer>().DiePlayer += DisableMovement;
        FindObjectOfType<SoundBackground>().soundSpeed += SuperSpeed;
        FindObjectOfType<SoundBackground>().DisableSoundSpeed += NormalSpeed;
        currentSpeed = speed;
    }
    private void Start()
    {
        
    }
    protected virtual void BaseMove()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    void NormalSpeed()
    {
        currentSpeed = speed;
    }
    void SuperSpeed()
    {
        currentSpeed = superSpeedEnemies;
    }
    void DisableMovement()
    {
        currentSpeed = 0f;
    }
}
