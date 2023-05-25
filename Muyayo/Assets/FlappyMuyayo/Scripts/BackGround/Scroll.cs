using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;
    private Rigidbody2D rb;
    private float stop = 0f;
    private void Awake()
    {
        
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
    }

    private void Update()
    {
        
    }
}
