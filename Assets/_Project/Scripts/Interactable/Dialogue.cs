using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour, InteractableObject
{


    [SerializeField] private UnityEvent _onWin = new();
    [SerializeField] private GameObject gameWinPanel;

    private void Start()
    {
        HideGameWinPanel();
    }
    public void Interact()
    {


        ShowGameWinPanel();



    }
   
       

    private void ShowGameWinPanel()
    {
        if (gameWinPanel != null)
        {
            gameWinPanel.SetActive(true);
       
        }
    }

    private void HideGameWinPanel()
    {
        if (gameWinPanel != null)
        {
            gameWinPanel.SetActive(false);
        }
    }
}
