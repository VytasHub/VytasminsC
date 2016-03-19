using UnityEngine;
using System.Collections;

public class Gui_S1 : MonoBehaviour 
{

	//public Text curlCount;

	// Use this for initialization
	void Start () 
	{
		//GUI.Label(new Rect(20, 25, Screen.width, Screen.height), "Count: "+ Global.repCounter);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//guiText.text
		//goldLabel.GetComponent<Text>().text = "GOLD: " + Global.repCounter;




	}


	void OnGUI ()
	{
		//GUI.skin.label.fontSize = 20;
		//GUI.color = Color.black;

		ThalmicHub hub = ThalmicHub.instance;

		//GUI.Label(new Rect(160, 25, Screen.width, Screen.height), "Count: "+ Global.repCounter);

		GUIStyle style = new GUIStyle ();
		style.font = (Font)Resources.Load ("LemonMilk",typeof (Font));
		style.fontSize = 50;
		style.normal.textColor = Color.black;
		GUI.Label(new Rect(120, 0, Screen.width, Screen.height), "Count: "+ Global.repCounter, style);


		// Access the ThalmicMyo script attached to the Myo object.
	

	}






}
