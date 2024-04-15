using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActivate : MonoBehaviour
{
    public GameObject monster;
    public GameObject Player;
    public float lightTime;
    public Input_Handler _Handler;
    public bool EnemyOn = false;
    // Start is called before the first frame update
    void Start()
    {
        monster.SetActive(false);   
        lightTime = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (_Handler._lanternOn) 
        {
            lightTime += Time.deltaTime;
            lightTime = Mathf.Min(15, lightTime);
        }
        else 
        {
            lightTime -= Time.deltaTime;
            lightTime = Mathf.Max(0, lightTime);
        }
        Monster();
    }

    public void Monster()
    {
        if (lightTime >= 11)
        {
            monster.SetActive(true);
            EnemyOn = true;
        } else if (lightTime <= 10)
        {
            monster.SetActive(false);
            EnemyOn = false;
        }
    }
}
