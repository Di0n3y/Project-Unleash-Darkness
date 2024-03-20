using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Door_light : MonoBehaviour
{
    public float floorLights = 0;
    public int floorTrigger;
    public bool _openDoor = false;
    public bool moveDoorUp = false;
    public bool moveDoorDown = false;
    public Transform _limitDoorDown;
    public Transform _limitDoorUp;

    [HideInInspector] public Floor_Light resetFloor;
    // Start is called before the first frame update
    void Start()
    {
        floorLights = 0;
        _openDoor = false;
    }

    // Update is called once per frame
    void Update()
    {
        float Abajo = _limitDoorDown.position.y;

        float Arriba = _limitDoorUp.position.y;
        if (floorLights == floorTrigger)
        {

            moveDoorUp = true;
            floorLights = 0;

        }


        if (moveDoorUp == true)
        {
            transform.Translate(0, +1 * Time.deltaTime, 0);
            resetFloor = Object.FindFirstObjectByType<Floor_Light>();
            resetFloor.resettingFloor = +1;
        }
        else if (moveDoorUp == false)
        {
            transform.Translate(0, 0, 0);
        }
        if (moveDoorDown == false)
        {
            transform.Translate(0, 0, 0);
        }
        else if (moveDoorUp == false)
        {
            transform.Translate(0, -1 * Time.deltaTime, 0);

        }
        if (transform.position.y >= Arriba)
        {
            moveDoorUp = false;
            moveDoorDown = true;


        }
        if (transform.position.y <= Abajo)
        {

            moveDoorDown = false;
        }
    }

}
