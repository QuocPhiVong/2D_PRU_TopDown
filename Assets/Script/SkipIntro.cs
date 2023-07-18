using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class SkipIntro : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button button;
    public void SkipIntroduction()
    {
        //SceneManager.LoadScene("Scene1");
        //videoPlayer.Stop();
        videoPlayer.enabled = false;
        //button = GetComponent<Button>(); // Gán giá trị cho biến myButton bằng cách tìm đối tượng Button trong cùng component
        button.gameObject.SetActive(false);
    }
}
