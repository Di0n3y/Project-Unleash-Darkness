using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    

    private PlayerStateMachine _stateMachine;

    public GameObject PlayerModel;




    public float health = 100;
    public float platform = 100;
    public bool isMoving=false;












    public AudioSource _PlayerAudioSource;




    public Animator visualObject;


    public void Death()
    {

    }



    void Awake()
    {
       


    }


    void Update()
    {
        //if (Time.frameCount % 2 == 0)
        _stateMachine?.Tick();
    }
}

