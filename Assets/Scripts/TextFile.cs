// // using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.IO;
// using System.Linq;

// public class TextFile : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public string filename = "Assets/Test.txt";
//     public float some_variable;
//     public string textToWrite = "Speed : " + MetersDemo.styleSpeed + " " + "Depth: " + MetersDemo.depthValue ;

//   public  void Start()
//     {
//         WriteToFile();
//     }

//     // Update is called once per frame
//     public void WriteToFile () {
//         some_variable += Time.deltaTime;//update the variable with something;
//        // textToWrite = textToWrite + " " + some_variable.ToString();//create a proper string so we can read the file afterwards
//         File.AppendAllText(filename, textToWrite);//write to the file. No need to call Flush or Close. Note this does NOT overwrite the file every time you restart the game
//           Debug.Log("Written!");
//     }
  
// }
