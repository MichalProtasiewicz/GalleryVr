using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrunwaldController : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {

    }

    void Update()
    {

    }

    public void AudioPlay(AudioClip otherClip)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = otherClip;
            audioSource.Play();
        }
    }

}
