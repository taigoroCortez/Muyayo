using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class RestarGame : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<PanelMenuButton>().restarEvent += Restar;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restar();
        }
    }

    public void Restar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }


    
}
