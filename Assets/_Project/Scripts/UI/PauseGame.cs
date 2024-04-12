using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public GameObject panelPause;
    void Start()
    {
        panelPause.SetActive(false);
    }

    
    public void ActivePause()
    {

        panelPause.SetActive (true);
        Time.timeScale = 0F;

    }

    public void DesactivePause()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1F;
    }
}