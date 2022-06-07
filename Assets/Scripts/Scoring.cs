using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public GameObject  score;

    private void Start()
    {
        score.GetComponent<Text>().text="Kills: 0";
    }

    private void Update()
    {
        score.GetComponent<Text>().text = "Kills: " + Seperate.kill
            ;
    }
}
