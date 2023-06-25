using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject vfx;
    public GameObject vfx2;
    public Image image;

    private void Awake()
    {
        FindObjectOfType<PanelMenuButton>().playEvent += ActiveTutorial;
    }
    void Start()
    {
        vfx.gameObject.SetActive(false);
        vfx2.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
    }

    float init = 0;
    bool vfxBolean = false;
    private void Update()
    {
        if (vfxBolean)
        {
            init += Time.deltaTime;
        }
        if(init > 1f)
        {
            vfx2.gameObject.SetActive(true);
            //image.gameObject.SetActive(false);
        }
        if (init > 1.5f) {
            image.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
        
    }
    void ActiveTutorial()
    {
        vfx.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
        vfxBolean = true;
    }

    
}
