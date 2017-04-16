using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBoatRotation : MonoBehaviour
{
    public GameObject Boat;
    // Use this for initialization
    void Awake()
    {
        Boat = GameObject.Find("Boats and Hoes1");

    }

    // Update is called once per frame
    void Update()
    {

        transform.eulerAngles = new Vector3(0,0, Boat.transform.eulerAngles.z);
    }
}
