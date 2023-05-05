using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject[] child;
    Vector3 rotationSkin;
    [SerializeField] private float speed = 4f;
    bool move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            move = !move;
            
        }
        if (move) 
        {
            
            transform.Translate(Vector2.up * Time.deltaTime);
            transform.GetChild(0).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
            transform.GetChild(1).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
            transform.GetChild(2).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
        }
        else
        {
            transform.Translate(Vector2.down * Time.deltaTime);
            transform.GetChild(0).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));
            transform.GetChild(1).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));
            transform.GetChild(2).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));

        }
    }
}
