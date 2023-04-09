using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{   
    [SerializeField] GameObject loadingStartUI;
    [SerializeField] GameObject settingsUI;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        settingsUI.SetActive(false);
    }

    public void StartBT()
    {
        loadingStartUI.SetActive(true);
    }

    public void ResumeBT()
    {

    }

    public void SettingsBT()
    {
       settingsUI.SetActive(true);
    }

    public void QuitBT()
    {
        Application.Quit();
    }
    
    public void CloseSettingsBT()
    {
        settingsUI.SetActive(false);
    }
}
