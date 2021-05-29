using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootState : IState
{
    EnemySM _EnemySM;
    Transform PlayerTransform;

    public EnemyShootState(EnemySM _esm, Transform plyrTrans){
        this._EnemySM = _esm;
        this.PlayerTransform = plyrTrans;
    }
    public void Enter(){
        Debug.Log("ENTERING SHOOT STATE");
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
