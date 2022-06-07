using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatRight : MonoBehaviour
{
     public float floatStrength = 3.5f; // change to your liking
    // Update is called once per frame
    void FixedUpdate()
    {
         GetComponent<Rigidbody>().AddForce(Vector3.right * floatStrength);
    }
    }

