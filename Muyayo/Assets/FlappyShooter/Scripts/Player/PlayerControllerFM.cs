using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerFM : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform pointShoot;
    [SerializeField] private float upForce = 350f;

    private int leftFingerID;
    private int rightFingerID;
    private float halfScreenWidth;
    private Rigidbody2D playerRigidbody;
    void Start()
    {
        leftFingerID = -1;
        rightFingerID = -1;
        halfScreenWidth = Screen.width / 2f;
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void GetTouchInput()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < halfScreenWidth && leftFingerID == -1)
                    {
                        leftFingerID = touch.fingerId;
                        Debug.Log("Left");
                    }
                    else if (touch.position.x > halfScreenWidth && rightFingerID == -1)
                    {
                        rightFingerID = touch.fingerId;
                        Debug.Log("Right");
                    }
                    break;
            }
        }
    }

    public void Jump()
    {
        playerRigidbody.velocity = Vector2.zero;
        playerRigidbody.AddForce(Vector2.up * upForce);
    }

    public void Shootin()
    {
        Instantiate(bullet, pointShoot.position, pointShoot.rotation);
    }
}
