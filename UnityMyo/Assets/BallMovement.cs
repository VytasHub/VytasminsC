using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour 
{
	
	float curlX = 0;
	bool flip = false;

	void Start () 
	{
		
	}


	void Update () 
	{
		MoveBall();

	

	}



	void MoveBall()
	{
		gameObject.transform.position = new Vector3(0,(Global.xoutput/50)-4,0);
		Debug.Log("Development angles x: " + Global.xoutput + " y: " + Global.youtput + " z: " + Global.zoutput);

		if(Global.xoutput > 359.9)
		{
			flip = true;

		}

		if(flip)
		{
			Global.xoutput = Global.xoutput + 360;
			print ("Triger");
			flip = false;

		}


	}




}
