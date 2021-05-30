using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSM : StateMachine
{
   public ShootingState shootingState {get; private set;}
   public TalkingState talkingState {get; private set;}

   enum States {shooting, talking};

   [SerializeField]
   States startingState;

   [SerializeField]
    int playerHealth = 25;
    public CharacterController controller;
    public GameObject projectile;
    public GameObject explosion;
    
    [SerializeField, Range(0f,10f)]
      public float speed = 12f;

    [SerializeField]
    LayerMask mask;
    [SerializeField,Range(1,100f)]
    float raycastDistance = 5f;
    int damage = 5;

    [SerializeField]
    Transform camTransform;

    [SerializeField]
    Transform shootingTransform;

   private void Awake() {
      Debug.Log("PLAYER VARIABLES" + " " + PlayerVariables.playerHealth);
      playerHealth = PlayerVariables.playerHealth;
      speed = PlayerVariables.speed;
      raycastDistance = PlayerVariables.rayCastDistance;
      damage = PlayerVariables.damage;
      shootingState = new ShootingState(this,camTransform,projectile,raycastDistance, shootingTransform);
      talkingState = new TalkingState(this);
   }

   private void Start() {
      if(startingState == States.shooting)this.ChangeState(shootingState);
      else if(startingState == States.talking)this.ChangeState(talkingState);
   }

    public void moveCharacter(){
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x  +  transform.forward * y;
        controller.Move(move*speed*Time.deltaTime);

    }



    void OnCollisionEnter(Collision other) {
        Debug.Log("Collider " + other.gameObject);
        if(other.gameObject.tag == "Bullet")playerHealth-=damage;
        if(playerHealth <= 0)FindObjectOfType<LevelLoader>().GetComponent<LevelLoader>().LoadNextLevel();
    }
}
