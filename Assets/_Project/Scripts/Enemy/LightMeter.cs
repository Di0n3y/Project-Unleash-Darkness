using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightMeter : MonoBehaviour
{
    public Image circleImage;
    public EnemyActivate enemyScript;

    void Update()
    {

        circleImage.fillAmount = enemyScript.lightTime / 10f;
    }
}
