using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    public float maxRotateValue = 200; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.value * maxRotateValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
