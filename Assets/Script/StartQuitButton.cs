using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Script
{
    public class StartQuitButton:MonoBehaviour
    {
        public void ChangeScene()
        {
            SceneManager.LoadScene("StartScene");
        }
        /*public void QuitGame()
        {
            Application.Quit();
        }*/
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Quit();
        }

        public void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
}
