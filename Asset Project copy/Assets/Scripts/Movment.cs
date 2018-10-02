using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour {
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(1,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, 1, ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-1, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -1, ForceMode.VelocityChange);
        }







    }
}
