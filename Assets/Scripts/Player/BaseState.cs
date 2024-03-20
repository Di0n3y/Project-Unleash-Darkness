using MagasLib.StateMachine;
using UnityEngine;

public class BaseState : IState

{

    protected PlayerStateMachine stateMachine;

    public BaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }





    public void OnAnimationEnterEvent()
    {
        throw new System.NotImplementedException();
    }

    public void OnAnimationExitEvent()
    {
        throw new System.NotImplementedException();
    }

    public void OnAnimationTransitionEvent()
    {
        throw new System.NotImplementedException();
    }

    public virtual void OnEnter()
    {

    }

    public virtual void OnExit()
    {

    }

    public void OnTriggerEnterEvent(Collider other)
    {
        throw new System.NotImplementedException();
    }

    public void OnTriggerExitEvent(Collider other)
    {
        throw new System.NotImplementedException();
    }

    public void PhysicsTick()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Tick()
    {


    }
}
