using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public Transform mainCharacter; 

    void Update()
    {
        if (mainCharacter != null)
        {
            
            Vector3 lookDirection = mainCharacter.position - transform.position;

            
            transform.rotation = Quaternion.LookRotation(lookDirection.normalized);
        }
    }
}
