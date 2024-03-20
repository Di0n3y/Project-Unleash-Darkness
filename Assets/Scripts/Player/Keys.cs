using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using MagasLib.StateMachine;
using UnityEngine;

public class Keys : MonoBehaviour
{
    


    [SerializeField] private GameObject Key;
    [SerializeField] private GameObject Door;
    public Transform _limitDoorUp;
    public Transform _limitDoorDown;

    public bool hasKey = false;
    public bool moveDoor = false;
    public bool moveDoorDown = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        float Abajo = _limitDoorDown.position.y;

        float Arriba = _limitDoorUp.position.y;
        
        if (moveDoor == true)
        {
            Door.transform.Translate(0, +1 * Time.deltaTime, 0);
        }else if(moveDoor == false) 
        {
            Door.transform.Translate(0, 0, 0);
        }
        if (moveDoorDown == false)
        {
            Door.transform.Translate(0, 0, 0);
        }else if (moveDoor == false)
        {
            Door.transform.Translate(0, -1*Time.deltaTime, 0);

        }
        if (Door.transform.position.y >=Arriba)
        {
            moveDoor = false;
            moveDoorDown = true;
            Door.transform.Translate(0, 0, 0);



        }
        if (Door.transform.position.y <= Abajo)
        {

            moveDoorDown = false;
            Key.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Key")
        {
            hasKey = true;
            Key.SetActive(false);

        } else if ((collision.gameObject.tag == "Door") && (hasKey == true))
        {

            hasKey = false;
            moveDoor= true;
            moveDoorDown= false;


        }


    }

}
