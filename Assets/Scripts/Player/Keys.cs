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
        
    }

    // Update is called once per frame
    void Update()

    {
       

        if (moveDoor == true)
        {
            Door.transform.Rotate(0, -1* Time.deltaTime, 0);
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


        }


    }

}
