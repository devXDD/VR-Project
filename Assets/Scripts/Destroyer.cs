using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject target;
  void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Touchable")
        {
            Debug.Log("Collision Triggered");
            Destroy(target);
        }
        else
        {
             Destroy(target);
           // Destroy(gameObject);
        }
    }
}
