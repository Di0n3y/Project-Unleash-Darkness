using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour, InteractableObject
{


    [SerializeField] private UnityEvent _onWin = new();
    [SerializeField] private GameObject gameWinPanel;
    public AudioClip DialogueSound;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(DialogueSound);
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
