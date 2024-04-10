using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));

        transform.Translate(0, 0, 1 * 2f * Time.deltaTime);

    }
}
