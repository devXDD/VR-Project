using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetection : MonoBehaviour
{
  

    public GameObject target;
    public GameObject myPrefab;
    public bool spawn = false;
 
  private  void OnCollisionEnter(Collision col)
    {
        while(spawn==false)
        {
       Destroy(target);
        Debug.Log("Collision Entered");
       Instantiate(myPrefab, new Vector3(1, 1, 1), Quaternion.identity);
       spawn = true;
        }
    }

}
