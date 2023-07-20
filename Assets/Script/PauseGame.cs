using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isGamePaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Nếu trạng thái trò chơi là đang chạy, tạm dừng trò chơi
            if (isGamePaused == false)
            {
                Time.timeScale = 0; // Đặt timeScale về 0 để dừng thời gian trong trò chơi
                isGamePaused = true;
            }

            else
            {
                Time.timeScale = 1; 
                isGamePaused = false;
            }
        }
    }

    void Start()
    {
        isGamePaused = false;
        Time.timeScale = 1;
    }
}
