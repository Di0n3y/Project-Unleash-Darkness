using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void LoadLevel(string name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name);
    }

    public void QuitApp()

    {

        Application.Quit();

    }



}
