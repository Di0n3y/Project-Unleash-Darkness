using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using MagasLib.StateMachine;
using UnityEngine;

public class Keys : MonoBehaviour
{
    


    [SerializeField] private GameObject Key;
    [SerializeField] private GameObject Door;
  

    public bool hasKey = false;
    public bool moveDoor = false;




    // Start is called before the first frame update
    void Start()
    {
        Key.SetActive(true);
        hasKey = false;
        moveDoor = false;
    }

    // Update is called once per frame
    void Update()

    {
       
        if (hasKey == false) 
        {
            moveDoor = false;

        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Key")
        {
            hasKey = true;
            Key.SetActive(false);

        } if ((collision.gameObject.tag == "Door") && (hasKey == true))
        {

            hasKey = false;
            moveDoor= true;


        }
        if (moveDoor == true)
        {
            Door.transform.Rotate(0, 90, 0);
            Door.transform.Translate(0, 0, -1);
        }else if (moveDoor == false)
        {
            Door.transform.Rotate(0, 0, 0);
            Door.transform.Translate(0, 0, 0);
        }


    }

}
