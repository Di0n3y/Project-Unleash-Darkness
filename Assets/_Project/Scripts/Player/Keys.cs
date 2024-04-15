using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using MagasLib.StateMachine;
using UnityEngine;

public class Keys : MonoBehaviour
{
    

    [SerializeField] private GameObject Door1;
    [SerializeField] private GameObject Door2;





    public bool hasKey = false;
    public int keyCount;
    public bool moveDoor1 = false;
    public bool moveDoor2 = false;





    // Start is called before the first frame update
    void Start()
    {
        hasKey = false;
        moveDoor1 = false;
        moveDoor2 = false;

    }

    // Update is called once per frame
    void Update()

    {
       
       if(keyCount >=1)
        {
            hasKey=true;
        }if(keyCount == 0) 
        {
            hasKey = false;
        }else if(keyCount < 0) 
        {
            keyCount = 0;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Key")
        {
            keyCount++;

        }
        if ((collision.gameObject.tag == "Door") && (hasKey == true))
        {

            keyCount--;
            moveDoor1 = true;



        }
        if (moveDoor1 == true)
        {
            Door1.transform.Rotate(0, 90, 0);
            Door1.transform.Translate(0, 0, -1);
            moveDoor1 = false;
        }

        if ((collision.gameObject.tag == "Door2") && (hasKey == true))
        {

            keyCount--;
            moveDoor2 = true;



        }
        if (moveDoor2 == true)
        {
            Door2.transform.Rotate(0, 0, -90);
            Door2.transform.Translate(-1, 0, 0);
            moveDoor2 = false;
        }

    }


}
