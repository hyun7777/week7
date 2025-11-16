using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : StateBase
{
    public override void Enter()
    {
        Debug.Log("WalkEnter");
    }

    public override void Exit()
    {
        Debug.Log("WalkExit");
    }

    public override void UpdateState()
    {
        Debug.Log("WalkUpdate");
    }
}