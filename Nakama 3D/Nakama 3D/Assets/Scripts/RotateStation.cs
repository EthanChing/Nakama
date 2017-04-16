using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStation : MonoBehaviour
{
    public GameObject cannon;
    public GameObject boat;
    public int rotationSpeed;
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {

        
        float directionRotation = 0;
        //Modulus 360 to account if rotate in negative direction at same angle.
        float currentBoatRotation = boat.transform.rotation.z % 360;
        if (Input.GetKey(KeyCode.W))
        {
            if (currentBoatRotation > 90.0f && currentBoatRotation < 270.0f)
                directionRotation = 1;
            else
                directionRotation = -1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if ((currentBoatRotation > 90.0f && currentBoatRotation < 270.0f))
                directionRotation = -1;
            else
                directionRotation = 1;
        }
        cannon.transform.eulerAngles += new Vector3(0, 0, Time.deltaTime * directionRotation * rotationSpeed);
    }
}
