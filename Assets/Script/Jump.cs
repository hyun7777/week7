using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : StateBase
{
    public override void Enter()
    {
        Debug.Log("JumpEnter");
    }

    public override void Exit()
    {
        Debug.Log("JumpExit");
    }

    public override void UpdateState()
    {
        Debug.Log("JumpUpdate");
    }
}
