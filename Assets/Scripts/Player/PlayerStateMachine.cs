using MagasLib.StateMachine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{

    public readonly Player player;
    public Idle IdleState { get; }
    public Move MoveState { get; }
    





    public PlayerStateMachine(Player player)
    {

        this.player = player;
        IdleState = new Idle(this);

        InitializeStatesTransitions();
        SetState(IdleState);
        //SetState(IdleState);
    }

    public void InitializeStatesTransitions()
    {
        //AddAnyTransition();
        





    }

}
