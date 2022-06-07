using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float floatStrength = 3.5f; // change to your liking
    // Update is called once per frame
    void FixedUpdate()
    {
         GetComponent<Rigidbody>().AddForce(Vector3.left * floatStrength);
    }
}
