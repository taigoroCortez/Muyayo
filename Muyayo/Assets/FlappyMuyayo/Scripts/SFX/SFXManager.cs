using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    private static SFXManager instance;
    public static SFXManager Instance => instance;

    public AudioEvent touchPlayer;
  


    private AudioSource source;

    public bool touch = false;
    public bool coin = false;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(touch) touchPlayer.Play(source);
     
        
    }

    public void PlaySound(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
   
}
