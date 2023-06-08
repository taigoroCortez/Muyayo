using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sfx-", menuName = "Scriptable/SFX")]
public class SimpleAudioEvent : AudioEvent
{
    public AudioClip clip;
    [Range(0,1)]
    public float volume;

    
    public override void Play(AudioSource source)
    {
        source.volume = volume;
        source.clip = clip;
        source.Play();
       // source.Stop();
        //source.PlayOneShot(clip);
    }

}
