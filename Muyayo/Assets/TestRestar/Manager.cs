using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject panel;
    private void Awake()
    {
        panel = GameObject.FindGameObjectWithTag("PanelesInGame");

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
