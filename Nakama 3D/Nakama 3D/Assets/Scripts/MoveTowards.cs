using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {
    public GameObject lead;
    public float speed;
	// Use this for initialization
	void Awake()
    {
        lead = GameObject.Find("lead");
        
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, lead.transform.position, step);
	}
}
