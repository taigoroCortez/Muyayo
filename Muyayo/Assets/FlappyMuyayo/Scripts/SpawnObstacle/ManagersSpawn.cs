using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersSpawn : MonoBehaviour
{
    public GameObject[] spawn;

    private float initTime = 0f;
    private float initTimeBirdPlomo = 0f;
    private float initTimeBirdBlack = 0f;
    [SerializeField] private float nextSpawnBirdRed = 30f;
    [SerializeField] private float nextSpawnCoinSilver = 30f;
    [SerializeField] private float nextSpawnCoinBronce = 30f;
    [SerializeField] private float nextSpawnBirdPlomo = 60f;
    [SerializeField] private float nextSpawnBirdBlack = 90f;

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
        spawn[3].SetActive(false);  //silver
        spawn[4].SetActive(false);  //bronce
        spawn[5].SetActive(false);
        spawn[6].SetActive(false); //bird black

    }

    // Update is called once per frame
    void Update()
    {
        if (activeTimer)
        {
            initTime += Time.deltaTime;
            initTimeBirdPlomo += Time.deltaTime;
            initTimeBirdBlack += Time.deltaTime;
        }
            

   
        if(initTime > nextSpawnBirdRed)
        {
            spawn[1].SetActive(true);   //bird red
        }
        if (initTime > nextSpawnCoinSilver)
        {
            spawn[3].SetActive(true);
        }
        if (initTime > nextSpawnCoinBronce)
        {
            spawn[4].SetActive(true);
        }
        if(initTimeBirdPlomo > nextSpawnBirdPlomo)
        {
            spawn[5].SetActive(true);
            StartCoroutine(DisactiveSpawnBridPlomo(6,5));
            initTimeBirdPlomo = 0f;
        }

        if(initTimeBirdBlack > nextSpawnBirdBlack)
        {
            spawn[6].SetActive(true);
            StartCoroutine(DisactiveSpawnBridPlomo(2, 6));
            initTimeBirdBlack = 0f;
        }
    }

    void SetInitial()
    {
        activeTimer = true;
        spawn[0].SetActive(true);
        spawn[1].SetActive(false);
        spawn[2].SetActive(true);
        spawn[5].SetActive(false);
    }

    IEnumerator DisactiveSpawnBridPlomo(float time,int numSpawn)
    {
        yield return new WaitForSeconds(time);
        spawn[numSpawn].SetActive(false);
    }
}
