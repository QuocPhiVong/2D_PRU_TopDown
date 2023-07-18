using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement1 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isMuted = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0f : 1f;
        }
    }
}
