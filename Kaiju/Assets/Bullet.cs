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
        target = GameObject.FindGameObjectWithTag("Player").transform.position;
        Debug.Log("TARGET " + target);
    }
    // Update is called once per frame
    void Update(){
        if(Vector3.Distance(this.transform.position,target) < 0.01f)Destroy(this.gameObject);
        counter -= Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.transform.position, target*bulletSpeed*Time.deltaTime,1f);
        if(counter <= 0)Destroy(this.gameObject);
    }
}
