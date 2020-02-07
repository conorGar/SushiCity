using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IActorState<State_Type, Trigger_Type>
{
    State_Type GetState();
    IActorState<State_Type, Trigger_Type> SendTrigger(Trigger_Type T, GameObject actor, Animator animator, ref int flags);
    IActorState<State_Type, Trigger_Type> OnUpdate(Animator animator, ref int flags);
}
