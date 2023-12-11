using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspecialMove : MonoBehaviour
{
    public float amplitude = 1f;  // Amplitud del movimiento seno
    public float frequency = 1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newY = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector2(transform.position.x, newY);
    }
}
