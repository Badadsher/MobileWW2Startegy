using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{
    public void StartNewLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ResumeLevel()
    {
        
        SceneManager.LoadScene(1);
    }

    public void LoadingThisLevel()
    {
        Destroy(gameObject);
    }


}
