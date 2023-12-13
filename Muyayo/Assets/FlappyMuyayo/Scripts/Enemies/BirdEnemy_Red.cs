using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdEnemy_Red : BaseEnemies
{
    // Start is called before the first frame update
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
        MoveSinEnemies();
        
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
