using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdEnemy_Red : BaseEnemies
{
    // Start is called before the first frame update
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
        MoveSinEnemies();
    }
}
