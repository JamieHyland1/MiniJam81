using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Range(5f,150f)]
    float bulletSpeed = 5f;
    [SerializeField]
    float bulletLifeTime = .25f;

    [SerializeField]
    GameObject explosionFX;

    float counter = 0;
    Vector3 target;
    void Start(){
      counter = bulletLifeTime;
    }
    // Update is called once per frame
    void Update(){
        counter -= Time.deltaTime;
        if(counter <= 0) explode();
        transform.position = Vector3.MoveTowards(this.transform.position, this.transform.position + transform.forward * bulletSpeed * Time.deltaTime,5);
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("BULLET COLLISION" + " " + other.gameObject.name);
        if(other.gameObject.tag == "Enemy"){
            other.gameObject.GetComponent<EnemyHealth>().takeDamage(PlayerVariables.damage);
            explode();
        }
       
        
    }

    void explode(){
        Instantiate(explosionFX,this.transform.position,Quaternion.identity);
        Destroy(this.gameObject,0.2f);
    }
}
