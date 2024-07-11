using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a referance to the Rigidbody component called "rb"
    public Rigidbody rb;
   
    //Debug.Log("Hello World");
    //rb.useGravity = false;
    //rb.AddForce(0, 200, 500);
    
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // we marked this "Fixed"Update because we 
    // are using it to mass with physics.
    void FixedUpdate()
    {
        // Add Force of  on the z axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
