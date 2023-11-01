using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public AudioEvent tapPlayer;
    public AudioSource audio;
    Vector3 rotationSkin;
    [SerializeField] private float speed = 4f;
    bool move = false;
    public bool initMove;
    bool initMove2;
    int i = 0;
    float alto;
    float ancho;
    // Start is called before the first frame update
    private void Awake()
    {
        alto = Camera.main.orthographicSize;
        ancho = alto * Camera.main.aspect;
        FindObjectOfType<PanelMenuButton>().playEvent += InitMovePlayer;
        FindObjectOfType<PanelMenuButton>().playEvent += StarPosition;
        
    }
    void Start()
    {
        initMove = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            i++;
            move = !move;
            tapPlayer.Play(audio);
        }
        
        
        if (i >= 1)
        {
            initMove2 = true;
            i = 0;
        }
        if (initMove && initMove2)
        {
            if (move)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);

                transform.GetChild(0).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
                transform.GetChild(1).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
                transform.GetChild(2).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
                transform.GetChild(3).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
                transform.GetChild(4).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 25f));
            }
            else
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);

                transform.GetChild(0).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));
                transform.GetChild(1).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));
                transform.GetChild(2).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));
                transform.GetChild(3).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));
                transform.GetChild(4).gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -25f));
            }
        }

    }
   
    void InitMovePlayer()
    {
        initMove = true;
    }
    void StarPosition()
    {
        transform.rotation = Quaternion.Euler(Vector3.zero);
 
        transform.position = new Vector3(-ancho + 0.7f, 0f, 0f);
        
    }
    
}
