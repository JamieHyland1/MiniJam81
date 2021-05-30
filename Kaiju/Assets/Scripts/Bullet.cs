using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField, Range(50f,150f)]
    float bulletSpeed = 50f;
    [SerializeField]
    float bulletLifeTime = .25f;

    float counter = 0;
    Vector3 target;
    void Start(){
        counter = bulletLifeTime;
    }
    // Update is called once per frame
    void Update(){
        if(Vector3.Distance(this.transform.position,target) < 0.01f)Destroy(this.gameObject);
        counter -= Time.deltaTime;
        transform.position = Vector3.MoveTowards(this.transform.position, this.transform.position + transform.forward * bulletSpeed * Time.deltaTime,5);
        if(counter <= 0)Destroy(this.gameObject);
    }
}
