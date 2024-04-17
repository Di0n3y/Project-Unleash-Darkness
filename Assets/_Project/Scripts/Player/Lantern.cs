using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lantern : MonoBehaviour
{
    public int lightTime = 0;
    [HideInInspector]public Input_Handler lanterIsOn;
    // Start is called before the first frame update
    void Start()
    {
        lightTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
