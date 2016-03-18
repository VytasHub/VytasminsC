using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour 
{
	
	float curlX = 0;
	bool flip = false;

	void Start () 
	{
		//print("Starting " + Time.time);
		//StartCoroutine(WaitAndPrint(2.0F));
		//print("Before WaitAndPrint Finishes " + Time.time);
	}


	void Update () 
	{
		MoveBall();

	}



	void MoveBall()
	{
		gameObject.transform.position = new Vector3(0,(Global.xoutput/50)-4,0);
		//Debug.Log("Development angles x: " + Global.xoutput + " y: " + Global.youtput + " z: " + Global.zoutput);


	}

	IEnumerator WaitAndPrint(float waitTime) 
	{
		yield return new WaitForSeconds(waitTime);
		print("WaitAndPrint " + Time.time);
	}




}
