using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{


	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width/2.5f,Screen.width/10, Screen.width/5,Screen.width/10), "Scene_1")) 
		{
			Application.LoadLevel (1);
		}
		if (GUI.Button (new Rect (Screen.width/2.5f,Screen.width/4.6f, Screen.width/5,Screen.width/10), "Scene_2")) 
		{
			Application.LoadLevel (2);

		}
		if (GUI.Button (new Rect (Screen.width/2.5f,Screen.width/3, Screen.width/5, Screen.width/10), "Scene_3")) 
		{
			Application.LoadLevel (3);

		}
		if (GUI.Button (new Rect (Screen.width/2.5f, Screen.width/2, Screen.width/5,Screen.width/10), "Exit")) 
		{
			Application.Quit();

		}
	}



}
