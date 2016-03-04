using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour 
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
		GUI.skin.label.fontSize = 20;
		GUI.color = Color.black;

		ThalmicHub hub = ThalmicHub.instance;

		GUI.Label(new Rect(20, 25, Screen.width, Screen.height), "Count: "+ Global.repCounter);

		// Access the ThalmicMyo script attached to the Myo object.
	

	}






}
