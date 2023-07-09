using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        DontDestroyOnLoad(transform.gameObject);
    }

    public void PlayOneShot(AudioClip clip)
    {
        if(clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
