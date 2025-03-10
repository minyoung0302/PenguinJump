using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip audioClip;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("Bonus");
    }
    public static void SoundPlay()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
