using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToLive : MonoBehaviour
{
    [SerializeField, Range(0f,5f)]
    float time = 5f;
    void Start()
    {
        Destroy(this.gameObject,time);
    }
}
