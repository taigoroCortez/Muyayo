using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{
    float spriteWidth;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D box = GetComponent<BoxCollider2D>();
        spriteWidth = box.size.x;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -spriteWidth)
            ResetPosition();
    }

    void ResetPosition()
    {
        transform.Translate(new Vector3(2 * spriteWidth, 0f, 0f));
    }
}
