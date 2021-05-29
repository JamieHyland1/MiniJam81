using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public GameObject projectile;
    RaycastHit hit;
    [SerializeField, Range(0f,10f)]
      public float speed = 12f;

    [SerializeField]
    LayerMask mask;
    [SerializeField,Range(1,10f)]
    float raycastDistance;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x  +  transform.forward * y;
        controller.Move(move*speed*Time.deltaTime);


        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Boom!");

            Physics.Raycast(transform.position,this.transform.forward, out hit, raycastDistance, mask);
            Debug.Log(hit.distance);
        }
    }

   
}
