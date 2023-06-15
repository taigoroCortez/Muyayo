using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdEnemy_Violet : BaseEnemies
{
    protected override void Awake()
    {
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
}
