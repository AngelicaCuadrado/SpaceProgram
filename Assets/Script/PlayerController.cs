using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{//Variable
    public float playerSpeed;//It will appears with the public in unity to change it any time, if qe change it to private we will not have access from unity
    // Start is called before the first frame update
    public float minX, maxX, minY, maxY;
    public GameObject laserBeam;
    public GameObject laserBeamSpawner;

    private float timer = 0;
    public float fireRate = 0.25f;

    void Start()
    {
        playerSpeed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement;
        float verticalMovement;
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        //Debug.Log("H: " + horizontalMovement + ", V: " + verticalMovement);

        Vector2 newVelocity = new Vector2(horizontalMovement, verticalMovement); //GetComponent<Ridigbody2D>().gravityScale =-1;
        GetComponent<Rigidbody2D>().velocity = newVelocity * playerSpeed; // to improve code is better to multiply by something becasue of the control (sensitive) to increase it 

        float newX, newY;
        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, minX, maxX);
        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, minY, maxY);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);

        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            GameObject goObj;
            goObj = GameObject.Instantiate(laserBeam, laserBeamSpawner.transform.position, laserBeamSpawner.transform.rotation);
            goObj.transform.Rotate(0.0f, 0.0f, -90.0f);

            timer = 0;
        }
        timer += Time.deltaTime;

    }

}