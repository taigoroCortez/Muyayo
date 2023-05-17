using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
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
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
        }
        else if(managerSelectPlayer.player == 2)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);

        }
        else if(managerSelectPlayer.player == 3)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
