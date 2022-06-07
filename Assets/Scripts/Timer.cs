using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    // public int secondsLeft = 30;
    // public bool timeLeft = false;
    public static float timeLef = 180;

    private void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + timeLef;
    }

    void Update()
    {
        // if(timeLeft==false && secondsLeft>0)
        // {
        //     StartCoroutine(TimerTake());  
        // }

        if(timeLef >0)
        {
            timeLef -= Time.deltaTime;
             textDisplay.GetComponent<Text>().text = "" +timeLef;
        }
         if(timeLef <0)
        {
            Debug.Log("Scene Changed");
                       SceneManager.LoadScene("DeathScene");
        }
    }

    // IEnumerator TimerTake()
    // {

    //     timeLeft = true;

    //     yield return new WaitForSeconds(1);
    //     secondsLeft -= 1;

    //     if (secondsLeft < 10)
    //     {
    //         textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
    //     }
    //     else
    //     {
    //         textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    //         timeLeft = false;
    //     }
    // }
}
