using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour

{
    public float beamSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(beamSpeed, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}