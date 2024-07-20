using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayEasy()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void PlayHard()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
