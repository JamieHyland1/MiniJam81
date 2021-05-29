using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySM : StateMachine
{
    public EnemyIdleState IdleState {get; private set;}
    public EnemyShootState ShootState {get; private set;}
    public EnemyWalkState WalkState {get; private set;}

    [SerializeField]
    Transform playerTransform;

    private void Awake() {
        IdleState = new EnemyIdleState(this,playerTransform);
        WalkState = new EnemyWalkState(this,playerTransform,10,10);
        ShootState = new EnemyShootState(this,playerTransform);


        this.ChangeState(IdleState);
    }

    private void OnEnable(){

    }

    private void OnDisable() {
        
    }




}
