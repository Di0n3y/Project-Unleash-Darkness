using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Limit : MonoBehaviour
{
    [SerializeField] private Transform _limitBottom;
    public bool Cayo = false;
    public bool  hasCheckpoint = false;

    public Vector3 Respawn;


    // Start is called before the first frame update
    void Start()
    {
        Respawn = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        float Cae = _limitBottom.position.y;


        Vector3 position = transform.position;
        if (position.y <= Cae)
        {

            Cayo = true;
            transform.position = Respawn;
           
        } else if (position.y >= Cae)
        {
            Cayo = false;
        }
        
        
        if (hasCheckpoint == true) 
        {
            Respawn = transform.position;
            hasCheckpoint = false;

        }







    }
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Checkpoint") && (hasCheckpoint == false))

        { 

            hasCheckpoint = true;
           



        }
        

    }
}
