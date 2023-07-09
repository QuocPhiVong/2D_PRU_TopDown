using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayer : MonoBehaviour
{
    public GameObject videoPlayer;

    public int delayTime;
    private void Start()
    {
        videoPlayer.SetActive(true);
        StartCoroutine(PlayDelay());
    }

    private IEnumerator PlayDelay()
    {
        yield return new WaitForSeconds(delayTime);
        Destroy(videoPlayer);
    }
}
