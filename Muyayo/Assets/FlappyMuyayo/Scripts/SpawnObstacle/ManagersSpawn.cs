using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersSpawn : MonoBehaviour
{
    public GameObject[] spawn;

    private float initTime = 0f;
    [SerializeField] private float nextSpawn = 30f;

    private bool activeTimer;
    private void Awake()
    {
        FindObjectOfType<PanelMenuButton>().playEvent+= SetInitial;
    }
    void Start()
    {
        spawn[0].SetActive(false);  //bird violet
        spawn[1].SetActive(false);  //bird red
        spawn[2].SetActive(false);  //coin_1
    }

    // Update is called once per frame
    void Update()
    {
        if(activeTimer)
            initTime += Time.deltaTime;

   
        if(initTime > nextSpawn)
        {
            spawn[1].SetActive(true);
        }
    }

    void SetInitial()
    {
        activeTimer = true;
        spawn[0].SetActive(true);
        spawn[1].SetActive(false);
        spawn[2].SetActive(true);
    }
}
