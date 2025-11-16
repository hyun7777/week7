using System.Collections.Generic;
using UnityEngine;

public enum CharacterState
{
    Idle, Walk, Jump
}

public abstract class StateBase : MonoBehaviour
{
    public CharacterState state;

    public abstract void Enter();
    public abstract void Exit();
    public abstract void UpdateState();
}

public class State : MonoBehaviour
{
    [SerializeField]
    CharacterState currentState;
    [SerializeField]
    StateBase[] stateBases;

    Dictionary<CharacterState, StateBase> stateDic;

    public void TransitionTo(CharacterState nextState)
    {
        if (currentState == nextState)
            return;

        stateDic[currentState].Exit();
        currentState = nextState;
        stateDic[nextState].Enter();
    }

    void Awake()
    {
        stateDic = new();
        foreach (StateBase stateBase in stateBases)
        {
            stateDic.TryAdd(stateBase.state, stateBase);
        }
        stateDic[currentState].Enter();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            TransitionTo(CharacterState.Idle);

        if (Input.GetKeyDown(KeyCode.W))
            TransitionTo(CharacterState.Walk);

        if (Input.GetKeyDown(KeyCode.Space))
            TransitionTo(CharacterState.Jump);

        stateDic[currentState].UpdateState();
    }
}
