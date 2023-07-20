using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagement : MonoBehaviour
{
    //private AudioSource[] allAudioSources;
    [SerializeField]Slider volumnSlider;
    void Start()
    {
        if(!PlayerPrefs.HasKey("Music Slider"))
        {
            PlayerPrefs.SetFloat("Music Slider", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeVolumn()
    {
        // Lấy tất cả các AudioSource trong scene
        //allAudioSources = FindObjectsOfType<AudioSource>();
        AudioListener.volume=volumnSlider.value;
    }

    private void Update()
    {
        // Kiểm tra nút M hoặc slider
        if (Input.GetKeyDown(KeyCode.M) || Input.GetButtonDown("Music Slider"))
        {
            // Tắt hoặc bật âm thanh
            //ToggleSound();
            AudioListener.volume = 0;
        }
    }

    /*private void ToggleSound()
    {
        // Duyệt qua tất cả các AudioSource và tắt/bật
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.mute = !audioSource.mute;
        }
    }*/

    private void Save()
    {
        PlayerPrefs.SetFloat("Music Slider", volumnSlider.value);
    }
    private void Load()
    {
        volumnSlider.value = PlayerPrefs.GetFloat("Music Slider");
    }

}



