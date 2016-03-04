using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour 
{
	
	float curlX = 0;
	void Start () 
	{
		
	}


	void Update () 
	{
		MoveBall();

	

	}



	void MoveBall()
	{
		
		
		gameObject.transform.position = new Vector3(0,Global.xoutput/50,0);
		Debug.Log("Development angles x: " + curlX + " y: " + Global.youtput + " z: " + Global.zoutput);
	}




}
