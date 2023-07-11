using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScreen : MonoBehaviour
{

    /*public string mainSceneName;
    public string loadingSceneName;
    public float loadingTime = 3f;

    private void Start()
    {
        StartCoroutine(LoadMainScene());
    }

    private IEnumerator LoadMainScene()
    {
        yield return new WaitForSeconds(loadingTime);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(mainSceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }*/
    public void ChangeScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}


