using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSprite : MonoBehaviour
{
    public Transform playerTransform;
   
    void Update()
    {
        Vector3 upAxis = Vector3.up;
        transform.rotation = Quaternion.LookRotation(Vector3.Cross(upAxis,  Vector3.Cross(upAxis, Camera.main.transform.forward)), upAxis);
    }
}
