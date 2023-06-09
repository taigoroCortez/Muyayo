using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagersSpawn : MonoBehaviour
{
    public GameObject[] spawn;

    private float initTime = 0f;
    private float initTimeBirdPlomo = 0f;
    [SerializeField] private float nextSpawnBirdRed = 30f;
    [SerializeField] private float nextSpawnCoinSilver = 30f;
    [SerializeField] private float nextSpawnCoinBronce = 30f;
    [SerializeField] private float nextSpawnBirdPlomo = 60f;

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

    }

    // Update is called once per frame
    void Update()
    {
        if (activeTimer)
        {
            initTime += Time.deltaTime;
            initTimeBirdPlomo += Time.deltaTime;
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
            StartCoroutine(DisactiveSpawnBridPlomo());
            initTimeBirdPlomo = 0f;
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

    IEnumerator DisactiveSpawnBridPlomo()
    {
        yield return new WaitForSeconds(6);
        spawn[5].SetActive(false);
    }
}
