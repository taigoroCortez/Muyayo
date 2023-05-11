using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 rotationSkin;
    [SerializeField] private float speed = 4f;
    bool move = false;
    public bool initGame;
    int i = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        FindObjectOfType<InitGameManager>().PlayGame += StarPosition;
    }
    void Start()
    {
        initGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (InitGameManager.Instance.initGame)
        {
            if (Input.GetMouseButtonDown(0))
            {
                i++;
                move = !move;
                Debug.Log(i);
            }
            if (i >= 1)
            {
                initGame = true;
            }
            
        }

        if (initGame)
        {
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

    void StarPosition()
    {
        transform.position = new Vector3(-1.5f, 0f, 0f);
        transform.rotation = Quaternion.Euler(Vector3.zero);
    }
}