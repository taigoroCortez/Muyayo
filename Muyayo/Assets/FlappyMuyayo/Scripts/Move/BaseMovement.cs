using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] private float superSpeedEnemies = 4f;
    [SerializeField] protected float speed = 3f;

    private void Awake()
    {
        FindObjectOfType<DeadPlayer>().DiePlayer += DisableMovement;
        FindObjectOfType<SoundBackground>().soundSpeed += SuperSpeed;
    }
    protected virtual void BaseMove()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void SuperSpeed()
    {
        speed = superSpeedEnemies;
    }
    void DisableMovement()
    {
        speed = 0f;
    }
}
