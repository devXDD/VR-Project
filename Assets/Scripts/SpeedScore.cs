using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScore : MonoBehaviour
{
   [SerializeField] public GameObject averageSpeed;
    float styleSpeed = 0f;
    int counter = 0;
    float average = 0f;
    // public HapticPlugin HapticDevice = null;
    // Start is called before the first frame update
    void Start()
    {
     //  averageSpeed.GetComponent<Text>().text = "Speed: 0";
    }

    // Update is called once per frame
    void Update()
    {
      //  styleSpeed = styleSpeed + HapticDevice.stylusVelocityRaw.magnitude;
        counter++;
        average = styleSpeed/counter;
        //averageSpeed.GetComponent<Text>().text = "Speed: " + average;

    }
}
