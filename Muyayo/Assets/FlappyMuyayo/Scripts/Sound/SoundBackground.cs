using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundBackground : MonoBehaviour
{
    [SerializeField] private float timeSuperSpeed = 20f;
    public event Action soundSpeed;
    public event Action DisableSoundSpeed;
    AudioSource audioSource;
    
    [SerializeField] AudioClip clipsInGame;
    [SerializeField] AudioClip clipsGameOver;
    bool active;

    private void Awake()
    {
        FindObjectOfType<PanelMenuButton>().playEvent += ActiveSound;
        FindObjectOfType<DeadPlayer>().DiePlayer += PlayerDie;
        FindObjectOfType<DeadPlayer>().DiePlayer += SoundGameOver;
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //audioSource.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if( audioSource.time >= timeSuperSpeed && !active)
        {
            soundSpeed?.Invoke();
        }
        if(audioSource.time >= 73f && !active)
        {
            DisableSoundSpeed?.Invoke();
        }
       // Debug.Log(" tiempo de musica " +audioSource.time);
    }
  
    void PlayerDie()
    {
        active = true;
    }
    void ActiveSound()
    {
        audioSource.clip = clipsInGame;
        audioSource.loop = true;
        audioSource.Play();
        //audioSource.gameObject.SetActive(true);
    }
    void SoundGameOver()
    {
        audioSource.clip = clipsGameOver;
        audioSource.loop = false;
        audioSource.Play();
        //audioSource.Stop();

        // audioSource.gameObject.SetActive(false);
    }
}
