using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : IActorState<PlayerState, PlayerTrigger>
{
    public PlayerState GetState()
    {
        return PlayerState.WALKING;
    }

    public IActorState<PlayerState, PlayerTrigger> OnUpdate(Animator animator, ref int flags)
    {
        animator.Play("Walk");
        return null;
    }

    public IActorState<PlayerState, PlayerTrigger> SendTrigger(PlayerTrigger trigger, GameObject actor, Animator animator, ref int flags)
    {
        switch (trigger)
        {
            case PlayerTrigger.IDLE:
                animator.SetBool("Walking", false);
                return new PlayerIdle();
        }

        return null;
    }
}
