using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : IActorState<PlayerState,PlayerTrigger>
{
    public PlayerState GetState()
    {
        return PlayerState.IDLE;
    }

    public IActorState<PlayerState, PlayerTrigger> OnUpdate(Animator animator, ref int flags)
    {
        animator.Play("Idle");
        return null;
    }

    public IActorState<PlayerState, PlayerTrigger> SendTrigger(PlayerTrigger trigger, GameObject actor, Animator animator, ref int flags)
    {
        switch (trigger)
        {
            case PlayerTrigger.WALK:
                animator.Play("Walk");
                return new PlayerWalk();
        }

        return null;
    }
}
