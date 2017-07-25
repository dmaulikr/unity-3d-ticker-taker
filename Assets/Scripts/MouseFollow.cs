using UnityEngine;
using System.Collections;

public class MouseFollow : MonoBehaviour {
	
	float smooth = 5.0f;
	float tiltAngle = 10.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position; // 'pos' is a copy
		Vector3 tilt;
		float halfW = Screen.width/2;
		float thirdH = Screen.height/2;
		// Smoothly tilts a transform towards a target rotation.
		float tiltAroundZ = Input.GetAxis("Mouse Y") * tiltAngle * -2;
		float tiltAroundX = Input.GetAxis("Mouse X") * tiltAngle * 2;
		
		tilt = new Vector3(tiltAroundX, 0, tiltAroundZ);
		Quaternion target = Quaternion.Euler(tilt);
		
		// modify the copy
		pos.x = (Input.mousePosition.x - halfW) / halfW; 
		pos.z = (Input.mousePosition.y - thirdH) / thirdH; 
		
		transform.position = pos; // Updates the original
		
		// Dampen towards the target rotation
		transform.rotation = Quaternion.Slerp(transform.rotation,
			target, Time.deltaTime * smooth);
		
		// Debug
		//Debug.Log(pos.z);
	}
}
