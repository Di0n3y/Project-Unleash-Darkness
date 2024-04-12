using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows;

public class Floor_fall : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] public Transform _limitPlatform;
    public Vector3 Respawn;
    public bool stepped = false;

    void Start()
    {
        Respawn = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float para = _limitPlatform.position.y;
        Vector3 position = transform.position;

        if (stepped == true) 
        {
            transform.Translate(0, -2*Time.deltaTime, 0);
            
        }
         if (position.y <= para)
        {
            stepped = false;
        }
         if (stepped ==false)
        {
            transform.position = Respawn;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            
            stepped = true;
        }
    }
}
