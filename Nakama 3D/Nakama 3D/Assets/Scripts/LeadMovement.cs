using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadMovement : MonoBehaviour {


    private Rigidbody2D myRigidBody;
    // Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        var x = Input.GetAxis("ArrowHorizontal") * 3.0f;
        var y = Input.GetAxis("ArrowVertical") * 3.0f;

        myRigidBody.velocity = new Vector3(x, y, 0);
    }
}
