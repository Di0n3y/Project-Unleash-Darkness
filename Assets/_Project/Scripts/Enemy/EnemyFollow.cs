using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;
    public EnemyActivate yep;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(yep.EnemyOn == true)
        { 
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));

        transform.Translate(0, 0, 1 * 2f * Time.deltaTime);
        }else if ( yep.EnemyOn==false)
        {

            transform.Translate(0, 0, 0);
        }

    }
}
