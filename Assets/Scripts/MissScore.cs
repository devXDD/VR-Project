using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissScore : MonoBehaviour
{
    public GameObject miss;

    private void Start()
    {
        miss.GetComponent<Text>().text = "Miss: 0";
    }

    private void Update()
    {
        miss.GetComponent<Text>().text = "Miss: " + TargetShooter.miss
            ;
    }
}
