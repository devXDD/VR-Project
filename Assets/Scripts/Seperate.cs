using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine;

public class Seperate : MonoBehaviour
{
    //public GameObject target;
    public bool toWrite = true;
    public static int kill;
    public string filename = "Assets/Test.txt";
    public float some_variable;
    public string textToWrite = "Speed : " + MetersDemo.average;
    public string DepthTxt = "Depth: "+ MetersDemo.depthText ;

 

    void OutputKills()
    {
         File.AppendAllText("Assets/KillsTest.txt","Kills: "+  kill + "\n");
    }
    void Start () 
	{
        InvokeRepeating("OutputKills", 1.0f, 1f);
	}
	


 
    void RandomSpawn()
    {
         // transform.position = new Vector3(Random.Range(0, 5)*Time.deltaTime , Random.Range(-5, 3) , Random.Range(0, -10));
         // safe value = 0,10
         transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-5,0) ,  Random.Range(-5,5));
         
    }
    void TwelveSize()
    {
        transform.localScale = new Vector3((12), (12), (12));
        RandomSpawn();
       
        
    }
    void FourSize ()
    {
        transform.localScale = new Vector3((4), (4), (4));
         RandomSpawn();
       
       
    }

    void EightSize()
    {
         transform.localScale = new Vector3((8), (8), (8));
      RandomSpawn();
      
       
    }

    void SixSize()
    {
        transform.localScale = new Vector3((6), (6), (6));
       RandomSpawn();
       
        
    }

    private  void OnCollisionEnter(Collision col)
    {  
      //  Destroy(col.gameObject);
      if(col.gameObject.tag =="Plane")
      {
         kill--;
      }
       if(col.gameObject.tag =="Poke")
      {
         kill++;
      }
     
      if (kill < 1 && Timer.timeLef > 170)
        {
            TwelveSize();
        }
     if (kill >= 10 && Timer.timeLef > 170)
        {
            FourSize();
        }

      if(kill >= 10 && Timer.timeLef > 160)
        {
            SixSize();
        }
      if (kill >= 20 && Timer.timeLef > 160)
        {
            FourSize();
        }

      if(kill >= 20 && kill <= 35 && Timer.timeLef > 140)
        {
            SixSize();
        }
      if (kill < 20 && Timer.timeLef > 140)
        {
            EightSize();
        }
      if (kill >35 && kill > 40 && Timer.timeLef > 140)
        {
            FourSize();
        }

       if (kill >= 30 && Timer.timeLef > 120)
        {
            SixSize();
        }
      if (kill < 30 && Timer.timeLef > 120)
        {
            EightSize();
        }
        if (kill < 20 && Timer.timeLef > 120)
        {
            TwelveSize();
        }
        if (kill >= 60 && Timer.timeLef > 120)
        {
            FourSize();
        }

        if (kill >= 45 && Timer.timeLef > 90)
        {
            SixSize();
        }
        if (kill >= 90 && Timer.timeLef > 90)
        {
            FourSize();
        }
        if (kill < 45 && Timer.timeLef > 90)
        {
            EightSize();
        }
        if (kill < 25 && Timer.timeLef > 90)
        {
            TwelveSize();
        }

        if (kill >= 60 && Timer.timeLef > 60)
        {
            SixSize();
        }
        if (kill >= 120 && Timer.timeLef > 60)
        {
            FourSize();
        }
       if (kill < 60 && Timer.timeLef > 60)
        {
            EightSize();
        }
      if (kill < 30 && Timer.timeLef > 60)
        {
            TwelveSize();
        }

        if (kill >= 75 && Timer.timeLef > 30)
        {
            FourSize();
        }
         if (kill < 75 && Timer.timeLef > 30)
        {
            SixSize();
        }
       if (kill < 35 && Timer.timeLef > 30)
        {
            EightSize();
        }
        if (kill < 15 && Timer.timeLef > 30)
        {
            TwelveSize();
        }

         if (kill >= 75 && Timer.timeLef > 0)
        {
            FourSize();
        }
         if (kill < 75 && Timer.timeLef > 0)
        {
            SixSize();
        }
       if (kill < 35 && Timer.timeLef > 0)
        {
            EightSize();
        }
        if (kill < 15 && Timer.timeLef > 0)
        {
            TwelveSize();
        }

    }
}
    
   

