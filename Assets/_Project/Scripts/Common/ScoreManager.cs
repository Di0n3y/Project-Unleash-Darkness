using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int _score = 0;
    private int _eliminations = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI eliminationsText;
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private int eliminationsRequired = 20;

    private void Start()
    {
       
        if (scoreText == null)
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        }
        if (eliminationsText == null)
        {
            eliminationsText = GameObject.Find("EliminationsText").GetComponent<TextMeshProUGUI>();
        }
      
        UpdateScoreText();
        UpdateEliminationsText();
    }

  
    public void IncreaseScore(int amount)
    {
        _score += amount;
        UpdateScoreText();
    }

    
    public void DecreaseScore(int amount)
    {
        _score -= amount;
      
        _score = Mathf.Max(_score, 0);
        UpdateScoreText();
    }

    
    public int GetScore()
    {
        return _score;
    }

    
    public void IncreaseEliminations()
    {
        _eliminations++;
        UpdateEliminationsText();

        if (_eliminations >= eliminationsRequired)
        {
            ShowVictoryPanel();
            PauseGame();
        }
    }

    
    public int GetEliminations()
    {
        return _eliminations;
    }

    
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "SCORE: " + _score.ToString();
        }
    }

 
    private void UpdateEliminationsText()
    {
        if (eliminationsText != null)
        {
            eliminationsText.text =  _eliminations.ToString() + "/" + eliminationsRequired.ToString();
        }
    }

    private void ShowVictoryPanel()
    {
        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true); 
        }
    }


    private void PauseGame()
    {
        Time.timeScale = 0f; 
    }
}
