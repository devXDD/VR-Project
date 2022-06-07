using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class MetersDemo : MonoBehaviour {

	public HapticPlugin HapticDevice = null;
	public GameObject Bunny = null;
	public Image depthMeter = null;
	public Image speedMeter = null;

	public Text button1Text = null;
	public Text button2Text = null;
	public Text speeder = null;
	public Text depther = null;

	private float depthMax = 25.0f;
	private float speedMax = 2000.0f;

	public static float styleSpeed = 0f;
    public int counter = 0;
    

	public static float depthValue = 0f;
    public int counterD = 0;
	
	public static float depthText = 0f;

    public static float averageDepth = 0f;
	public static float average = 0f;
	public static int hits = 0;

	public string name = "";
	public string SpeedUser = ""+average;
    public string Depth = ""+ averageDepth;
	public string Hits = "" + hits;



	void OutputTime() {
  			if (depthMeter != null)
			{
			// If we're touching the Bunny...
			if (HapticDevice.touching == Bunny)
			{
				// float depth = (1.0f / depthMax) * HapticDevice.touchingDepth;
				// depthMeter.fillAmount = depth;
				// depthValue = depthValue + HapticDevice.touchingDepth;
		
				// counterD++;
				// averageDepth = depthValue/counterD;
				// depther.GetComponent<Text>().text = "Depth: " + HapticDevice.touchingDepth;
				 File.AppendAllText("Assets/Test.txt","Depth: "+  HapticDevice.touchingDepth + "\n");
				 Debug.Log("Meter Written");
				// depthText = HapticDevice.touchingDepth * Time.deltaTime;

				} 
 			}
 		}

	void OutputSpeed() {
  			
				 File.AppendAllText("Assets/SpeedTest.txt","Speed: "+ average + "\n");
				 Debug.Log("Speed Written");
				// depthText = HapticDevice.touchingDepth * Time.deltaTime;

				}
 			
	// This updates two onscreen meters with data retrieved from the haptic device.
	void Update () 
	{
		

		if (HapticDevice == null)	return;

		/*
		 *	"touchingDepth" is a property of haptic devices.
		 *	It indicates how far the user has pushed the stylus intot he slighly rubbery surfaces 
		 *	of a 'touchable' object.
		 */

		hits = Seperate.kill;

		
		if (depthMeter != null)
		{
			// If we're touching the Bunny...
			if (HapticDevice.touching == Bunny)
			{
				float depth = (1.0f / depthMax) * HapticDevice.touchingDepth;
				depthMeter.fillAmount = depth;
				depthValue = depthValue + HapticDevice.touchingDepth;
		
				counterD++;
				averageDepth = depthValue/counterD;
				depther.GetComponent<Text>().text = "Depth: " + HapticDevice.touchingDepth;
				//  File.AppendAllText("Assets/Test.txt","Depth: "+  HapticDevice.touchingDepth + "\n");
				//  Debug.Log("Meter Written");
				// depthText = HapticDevice.touchingDepth * Time.deltaTime;

			} 
			else
				depthMeter.fillAmount = 0;
				//depther.GetComponent<Text>().text = "Depth: " + "0";
		}

		/*
		 *	"StylusVelocityRaw" is a property of haptic devices
		 *	It indicates how fast the stylus is moving in the real-world.
		 */		 
		if (speedMeter != null)
			speedMeter.fillAmount = (1.0f / speedMax) * HapticDevice.stylusVelocityRaw.magnitude;
			styleSpeed = styleSpeed + HapticDevice.stylusVelocityRaw.magnitude;
			//speeder.GetComponent<Text>().text = "Speed: " + HapticDevice.stylusVelocityRaw.magnitude;
			//Debug.Log("Speed: " + (1.0f / speedMax) * HapticDevice.stylusVelocityRaw.magnitude );
			counter++;
        	average = styleSpeed/counter;
			speeder.GetComponent<Text>().text = "Speed: " + average;
			//SpeedUser = ""+average;
        //averageSpeed.GetComponent<Text>().text = "Speed: " + average;


		/*
		 * "Buttons" is an array of ints.
		 * 1 = button pressed
		 * 0 = button not pressed
		 */
		if (HapticDevice.Buttons [0] == 1)
			button1Text.enabled = true;
		else
			button1Text.enabled = false;

		if (HapticDevice.Buttons [1] == 1)
			button2Text.enabled = true;
		else
			button2Text.enabled = false;

	}

	
	
 

	// Simple initialization.
	void Start () 
	{
		if (HapticDevice == null)
			HapticDevice = (HapticPlugin)FindObjectOfType(typeof(HapticPlugin));

		if( HapticDevice /* STILL */ == null )
			Debug.LogError("This script requires that Haptic Device be assigned.");

		if (depthMeter == null)
			Debug.LogError("This script requires a UI Image be linked to 'depthMeter'");
		if (speedMeter == null)
			Debug.LogError("This script requires a UI Image be linked to 'speedMeter'");
		

	
        InvokeRepeating("OutputTime", 1.0f, 1f);
		InvokeRepeating("OutputSpeed", 1.0f, 1f);


	}
	
}
