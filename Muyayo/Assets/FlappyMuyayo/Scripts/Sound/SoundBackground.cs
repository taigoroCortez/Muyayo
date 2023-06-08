using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundBackground : MonoBehaviour
{
    [SerializeField] private float timeSuperSpeed = 20f;
    public event Action soundSpeed;
    AudioSource audioSource;

    private void Awake()
    {
        FindObjectOfType<PanelMenuButton>().playEvent += ActiveSound;
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if( audioSource.time >= timeSuperSpeed)
        {
            soundSpeed?.Invoke();
        }
        Debug.Log(" tiempo de musica " +audioSource.time);
    }

    void ActiveSound()
    {
        audioSource.gameObject.SetActive(true);
    }
}
