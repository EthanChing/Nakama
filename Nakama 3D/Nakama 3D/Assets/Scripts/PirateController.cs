using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class PirateController : MonoBehaviour {

    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal") * 3.0f;
        var y = Input.GetAxis("Vertical") * 3.0f;

        myRigidbody.velocity = new Vector3(x, y, 0);
        float faceDeg = Vector3.Angle(gameObject.GetComponent<Rigidbody2D>().velocity.normalized, Vector3.right);
        if (gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 0.01)
        {
            if (gameObject.GetComponent<Rigidbody2D>().velocity.normalized.y < 0)
                faceDeg = -faceDeg;
            transform.eulerAngles = new Vector3(0,0, faceDeg);
        }
        
    }
}
