using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Door_light : MonoBehaviour
{
    public float floorLights = 0;
    public GameObject Door;
    public int floorTrigger;
    public bool _openDoor = false;
    public GameObject wallDoor;



    [HideInInspector] public Floor_Light resetFloor;
    // Start is called before the first frame update
    void Start()
    {
        floorLights = 0;

        _openDoor = false;
    }

    // Update is called once per frame
    void Update ()
    {
      
        if (floorLights >= floorTrigger)
        {

            _openDoor = true;
            floorLights = 0;

        }


        if (_openDoor == true)
        {
            
                Door.transform.Rotate(0, 0, -90);
                Door.transform.Translate(0, 0, 0);
            _openDoor = false;
            
        }
        else if (_openDoor == false)
        {
            Door.transform.Translate(0, 0, 0);
        }
       
    }
   

}
