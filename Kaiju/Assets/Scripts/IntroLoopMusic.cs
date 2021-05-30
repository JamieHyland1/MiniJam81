//Plays an intro to a song, then loops the song
//Attach to an object with an Audio Source
//Set intro to the intro (obvs) and set the Audio Source's AudioClip to the looping part of the song

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroLoopMusic : MonoBehaviour
{
    public AudioClip intro;
    AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.loop = true;
        source.playOnAwake = false;
        source.PlayOneShot(intro);
        source.PlayDelayed(intro.length);
    }
}
