using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum PlayerState
{
    NONE,
    IDLE,
    WALKING
}


public enum PlayerTrigger
{
    IDLE,
    WALK
}
public class PlayerStateController : ActorStateController<PlayerState,PlayerTrigger>
{

    protected new void Awake()
    {
        defaultState = new PlayerIdle();
        base.Awake();
    }


    protected override void AnyStateTrigger(PlayerTrigger trigger)
    {
        switch (trigger)
        {
            // any triggers that override all others goes here
        }
    }

    protected override void AnimationEventCompleted(Animator animator, Animator clip)
    {
        base.AnimationEventCompleted(animator, clip);

        switch (currentState.GetState())
        {
            //cases for any state changes that take place at the end of an animation
        }
    }
}
