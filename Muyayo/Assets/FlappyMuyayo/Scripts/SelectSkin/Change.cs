using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;
    public GameObject go4;
    public GameObject go5;

    public ManagerSelectPlayer managerSelectPlayer;
    // Start is called before the first frame update
    void Start()
    {
        managerSelectPlayer = GameObject.FindGameObjectWithTag("ManagerSelectPlayer").GetComponent<ManagerSelectPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        managerSelectPlayer.LoadData();
        
        if(managerSelectPlayer.player == 1)
        {
            go1.gameObject.SetActive(true);
            go2.gameObject.SetActive(false);
            go3.gameObject.SetActive(false);
            go4.gameObject.SetActive(false);
            go5.gameObject.SetActive(false);
            //transform.GetChild(0).gameObject.SetActive(true);
            //transform.GetChild(1).gameObject.SetActive(false);
            //transform.GetChild(2).gameObject.SetActive(false);
        }
        else if(managerSelectPlayer.player == 2)
        {
            go1.gameObject.SetActive(false);
            go2.gameObject.SetActive(true);
            go3.gameObject.SetActive(false);
            go4.gameObject.SetActive(false);
            go5.gameObject.SetActive(false);
            //transform.GetChild(0).gameObject.SetActive(false);
            //transform.GetChild(1).gameObject.SetActive(true);
            //transform.GetChild(2).gameObject.SetActive(false);

        }
        else if(managerSelectPlayer.player == 3)
        {
            go1.gameObject.SetActive(false);
            go2.gameObject.SetActive(false);
            go3.gameObject.SetActive(true);
            go4.gameObject.SetActive(false);
            go5.gameObject.SetActive(false);
            //transform.GetChild(0).gameObject.SetActive(false);
            //transform.GetChild(1).gameObject.SetActive(false);
            //transform.GetChild(2).gameObject.SetActive(true);
        }
        else if(managerSelectPlayer.player == 4){
            go1.gameObject.SetActive(false);
            go2.gameObject.SetActive(false);
            go3.gameObject.SetActive(false);
            go4.gameObject.SetActive(true);
            go5.gameObject.SetActive(false);
        }
        else if(managerSelectPlayer.player == 5){
            go1.gameObject.SetActive(false);
            go2.gameObject.SetActive(false);
            go3.gameObject.SetActive(false);
            go4.gameObject.SetActive(false);
            go5.gameObject.SetActive(true);
        }
    }
}
