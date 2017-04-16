using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStation : MonoBehaviour {
    private PirateController pirateScript;
    private RotateStation rotateScript;

    // Use this for initialization
    void Start() {

       pirateScript=  GameObject.FindGameObjectWithTag("Player").GetComponent<PirateController>();
       rotateScript=  GameObject.FindGameObjectWithTag("Station").GetComponent<RotateStation>();


    }
    void OnTriggerStay2D(Collider2D collider)
    {

        if (Input.GetKeyDown(KeyCode.F))
        {

            pirateScript.enabled = !pirateScript.enabled;
            rotateScript.enabled = !rotateScript.enabled;



        }
    }

    // Update is called once per frame
    void Update () {

       
	}
}
