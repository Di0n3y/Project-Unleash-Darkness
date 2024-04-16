using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

   public GameObject pausePanel;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0f : 1f; 

        if (pausePanel != null)
        {
            pausePanel.SetActive(isPaused); 
        }
    }

    public void ResumeGame()
    {
        TogglePause();
    }
}