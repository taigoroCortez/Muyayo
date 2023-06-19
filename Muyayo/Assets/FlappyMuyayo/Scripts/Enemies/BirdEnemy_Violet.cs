using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdEnemy_Violet : BaseEnemies
{
    protected override void Awake()
    {
        FindObjectOfType<DeadPlayer>().DiePlayer += Desactivar;
        base.Awake();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BaseMove();
    }

    void Desactivar()
    {
        StartCoroutine(TimerDisable());
    }

    IEnumerator TimerDisable()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}
