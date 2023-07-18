using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInStartMenu : MonoBehaviour
{
    public GameObject settingsPanel;

    private void Start()
    {
        // Ẩn màn hình "SettingsPanel" khi bắt đầu game
        settingsPanel.SetActive(false);
    }

    public void OnSettingsButtonClicked()
    {
        // Hiển thị màn hình "SettingsPanel" khi người dùng nhấn vào nút "Settings"
        settingsPanel.SetActive(true);
    }
    public void OnBackClicked()
    {
        // Hiển thị màn hình "SettingsPanel" khi người dùng nhấn vào nút "Settings"
        settingsPanel.SetActive(false);
    }
}


