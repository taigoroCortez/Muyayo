using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBackground : MonoBehaviour
{
    public GameObject[] backgrounds;

  

    private void Awake()
    {
        
        backgrounds = GameObject.FindGameObjectsWithTag("Background");
        foreach (var go in backgrounds)
        {
            go.SetActive(false);
        }
        var indexRandom = Random.Range(0, backgrounds.Length);
        backgrounds[indexRandom].SetActive(true);
       
        
    }

  
}
