using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool _newCheckpoint = false;
    public GameObject _Checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        _newCheckpoint = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _newCheckpoint = true;
            _Checkpoint.SetActive(false);
           
        }
    }
}
