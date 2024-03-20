using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    

    public void Start()
    {
    }

    public void MoveNow(Vector2 input)
    {
        transform.Translate(input.x * Time.deltaTime * _speed, 0,
            input.y * Time.deltaTime * _speed);
         
       
    }
    
}
