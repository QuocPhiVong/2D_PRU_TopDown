using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoPlayerThenMoveScene : MonoBehaviour
{
    public GameObject videoPlayer;

    public int delayTime;
    private void Start()
    {
        videoPlayer.SetActive(true);
        StartCoroutine(PlayDelay());
        DestroyAudio();
    }

    private IEnumerator PlayDelay()
    {
        yield return new WaitForSeconds(delayTime);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Destroy(player);
        Destroy(videoPlayer);
        SceneManager.LoadScene("StartMenu");
    }

    private void DestroyAudio()
    {
        GameObject audio = GameObject.FindGameObjectWithTag("AudioSource");
        Destroy(audio);
    }
}
