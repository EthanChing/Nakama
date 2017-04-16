using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour {
    private Rigidbody2D myRigidBody;
    public GameObject lead;
    private float speed = 5f;
    // Use this for initialization
    void Awake()
    {
        lead = GameObject.Find("lead");
        myRigidBody = GetComponent<Rigidbody2D>();
       
    }
    void FixedUpdate () {
       
        Vector3 direction = (lead.transform.position - transform.position).normalized;
        myRigidBody.MovePosition(transform.position + direction *speed * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 difference = lead.transform.position - transform.position;
        var angle = Mathf.Atan2(-difference.y, -difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
 
    }
}
