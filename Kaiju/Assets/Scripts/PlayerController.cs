using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    int playerHealth = 25;
    public CharacterController controller;
    public GameObject projectile;
    
    [SerializeField, Range(0f,10f)]
      public float speed = 12f;

    [SerializeField]
    LayerMask mask;
    [SerializeField,Range(1,100f)]
    float raycastDistance = 5f;

    [SerializeField]
    Transform camTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

       
    }

   

   
}
