using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public Vector3 myPos;
    public Transform myPlay;

    public void Update()
    {
        transform.position = myPlay.position + myPos;
    }
}
