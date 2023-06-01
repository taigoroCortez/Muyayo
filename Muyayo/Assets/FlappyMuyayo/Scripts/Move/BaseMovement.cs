using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] protected float speed = 3f;

    private void Awake()
    {
        FindObjectOfType<DeadPlayer>().DiePlayer += DisableMovement;
    }
    protected virtual void BaseMove()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void DisableMovement()
    {
        speed = 0f;
    }
}
