using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelWinDie : MonoBehaviour
{
    //public GameObject settingsPanelWin;
    public GameObject settingsObjectDie;
    
    // Start is called before the first frame update
    private void Start()
    {
        // Ẩn màn hình "SettingsPanel" khi bắt đầu game
        settingsObjectDie.SetActive(false);
    }
    public void OnClickCloseButton()
    {
        //ẩn màn hình "SettingPanel" khi click close button
        settingsObjectDie.SetActive(false);
    }
    public void showDiePanel()
    {
        //GameObject settingsPanelDie;
        settingsObjectDie.SetActive(true);
    }

}
