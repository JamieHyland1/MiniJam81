using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingState : IState
{
    PlayerSM _playerSm;
    

    public TalkingState(PlayerSM _playerSM){
        this._playerSm = _playerSM;
    }
    public void Enter(){
        Debug.Log("Entering talking state");
    }

    public void Exit(){
        Debug.Log("Leaving closing state");
    }

    public void FixedTick(){

    }

    public void Tick(){
        _playerSm.moveCharacter();


        
    }
}
