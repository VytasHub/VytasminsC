using UnityEngine;
using System.Collections;

public class Menu_S1 : MonoBehaviour 
{

	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width/20,Screen.width/1.75f, Screen.width/5, Screen.width/10), "Back")) 
		{
			Application.LoadLevel(0);
		}

	}


}
