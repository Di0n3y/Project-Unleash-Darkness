using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHp = 3;
    [SerializeField] private UnityEvent _onDie = new();
    private int _currentHp = default;
    [SerializeField] private GameObject gameOverPanel;



    private void Start()
    {
        _currentHp = _maxHp;
        HideGameOverPanel();
    }


    

    public void CollisionDamage()
    {
       
       
            DoDamage(10);
       
    }

    public void DoDamage(int val)
    {


            _currentHp -= Mathf.Abs(val);
            if (_currentHp <= 0)
            {
                _onDie?.Invoke();
            ShowGameOverPanel();
            _currentHp = _maxHp;
            }


        
        
    }

    private void ShowGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f; 
        }
    }

    private void HideGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }





}