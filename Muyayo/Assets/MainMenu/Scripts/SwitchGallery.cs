using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchGallery : MonoBehaviour
{
    public GameObject[] images;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        if (index >= images.Length) index = images.Length;
        if (index <= 0) index = 0;
        if (index == 0) images[0].gameObject.SetActive(true);
    }

    public void Next()
    {
        index += 1;
        for(int i = 0;i < images.Length; i++)
        {
            images[i].gameObject.SetActive(false);
            images[index].gameObject.SetActive(true);
        }
    }

    public void Previous()
    {
        index -= 1;
        for (int i = 0; i < images.Length; i++)
        {
            images[i].gameObject.SetActive(false);
            images[index].gameObject.SetActive(true);
        }
    }
}
