using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudioPlay : MonoBehaviour
{ 

    AudioSource myAudio;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        myAudio = GetComponent<AudioSource>();
        Invoke("playAudio", 38.0f);
        
    }

    void playAudio()
    {
        myAudio.Play();
        
    }
}
