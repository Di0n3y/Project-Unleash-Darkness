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
        HideDialoguePanel();
    }
    public void Interact()
    {


        ShowDialoguePanel();



    }
   
       

    private void ShowDialoguePanel()
    {
        if (gameWinPanel != null)
        {
            gameWinPanel.SetActive(true);
       
        }
    }

    private void HideDialoguePanel()
    {
        if (gameWinPanel != null)
        {
            gameWinPanel.SetActive(false);
        }
    }
}
