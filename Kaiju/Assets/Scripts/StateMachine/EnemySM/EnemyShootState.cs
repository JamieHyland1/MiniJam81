using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootState : IState
{
    EnemySM _EnemySM;
    Transform PlayerTransform;

    Animator animator;

    public EnemyShootState(EnemySM _esm, Transform plyrTrans, Animator animator){
        this._EnemySM = _esm;
        this.PlayerTransform = plyrTrans;
        this.animator = animator;
    }
    public void Enter(){
        Debug.Log("ENTERING SHOOT STATE");
        animator.SetTrigger("Shooting");
    }
    public void Exit(){
        Debug.Log("LEAVING SHOOT STATE");

    }
    public void FixedTick(){

    }
    public void Tick(){
        Debug.Log("BANG!");
        _EnemySM.ChangeState(_EnemySM.IdleState);
    }
}
