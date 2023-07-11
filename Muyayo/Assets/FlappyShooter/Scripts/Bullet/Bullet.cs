using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D bulletRB;
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        bulletRB.AddForce(Vector2.right * 100f);
    }
   

    
}
