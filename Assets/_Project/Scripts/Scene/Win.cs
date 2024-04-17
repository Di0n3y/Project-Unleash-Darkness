using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Win : MonoBehaviour
{
    
    [SerializeField] private UnityEvent _onWin = new();
    [SerializeField] private GameObject gameWinPanel;

    public AudioClip WinMusic;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        HideGameWinPanel();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            ShowGameWinPanel();
        }
    }

    private void ShowGameWinPanel()
    {
        if (gameWinPanel != null)
        {
            gameWinPanel.SetActive(true);
            Time.timeScale = 0f;
            audioSource.PlayOneShot(WinMusic);
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
