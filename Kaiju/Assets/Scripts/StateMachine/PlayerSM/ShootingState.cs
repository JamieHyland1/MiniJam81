using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingState : IState
{
    PlayerSM _playerSM;
    GameObject explosion;
    Transform camTransform;

    float rayCastDistance;
    public ShootingState(PlayerSM playerSM,Transform camTransform, GameObject explosion, float rayCastDistance){
        this._playerSM = playerSM;
        this.explosion = explosion;
        this.camTransform = camTransform;
        this.rayCastDistance = rayCastDistance;
    }
    public void Enter(){
        Debug.Log("In shooting state");
       
    }

    public void Exit(){
        Debug.Log("Leaving Shooting state");
    }

    public void FixedTick(){
        
    }

    public void Tick(){
       _playerSM.moveCharacter();


        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if(Physics.Raycast(camTransform.position,camTransform.forward, out hit, rayCastDistance)){
                Debug.Log(hit.transform.name + "hi ");
                MonoBehaviour.Instantiate(explosion,hit.point,Quaternion.identity);
                if(hit.collider.gameObject.tag == "Enemy"){
                    EnemyHealth e = hit.collider.gameObject.GetComponent<EnemyHealth>();
                    e.takeDamage(5);
                }
            }
        }
    }
}
