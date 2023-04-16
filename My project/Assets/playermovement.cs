using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward_force = 10;
    public float side_force = 10;
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(0,0,forward_force*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(side_force*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-side_force*Time.deltaTime,0,0);
        }
    }
}
