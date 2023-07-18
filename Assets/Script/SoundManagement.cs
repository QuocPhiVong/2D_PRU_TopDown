using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagement : MonoBehaviour
{
    private AudioSource[] allAudioSources;

    private void Awake()
    {
        // Lấy tất cả các AudioSource trong scene
        allAudioSources = FindObjectsOfType<AudioSource>();
    }

    private void Update()
    {
        // Kiểm tra nút M hoặc slider
        if (Input.GetKeyDown(KeyCode.M) || Input.GetButtonDown("Music Slider"))
        {
            // Tắt hoặc bật âm thanh
            ToggleSound();
        }
    }

    private void ToggleSound()
    {
        // Duyệt qua tất cả các AudioSource và tắt/bật
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.mute = !audioSource.mute;
        }
    }

}



