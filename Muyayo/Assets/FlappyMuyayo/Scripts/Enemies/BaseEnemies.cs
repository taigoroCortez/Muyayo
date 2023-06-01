using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class BaseEnemies : BaseMovement
{
    public float amplitude = 1;
   // private float lastChangeTimeY = 0;
    [SerializeField] float verticalSpeed=2f;

    Vector3 startPosition;
    void Start()
    {
        startPosition = transform.localPosition;
    }

    
    void Update()
    {
        
    }
    
    protected virtual void MoveSinEnemies()
    {
        transform.position += new Vector3(-1, amplitude * Mathf.Sin(Time.time * verticalSpeed), 0f) * Time.deltaTime * speed;
    }
}
