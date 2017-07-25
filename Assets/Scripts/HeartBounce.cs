using UnityEngine;
using System.Collections;

public class HeartBounce : MonoBehaviour {
	bool velocityWasStored = false;
	bool hasLost = false;
	int numHits = 0;
	static int bestScore = 0;
	int lastBest = 0;
	Vector3 storedVelocity;
	public GUIText hitCount;
	
	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "tray") {
			Debug.Log("yes! hit tray!");
			if (!velocityWasStored) {
				storedVelocity = rigidbody.velocity;
				velocityWasStored = true;
			}
			
			if (rigidbody.velocity.y > 1) {
				numHits ++;
			}
			
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, 
			storedVelocity.y, rigidbody.velocity.z);
		}
	}
	
	// Update is called once per frame
	void Update () {
		string str = "";
		if (!hasLost) {
			str = numHits.ToString();
		}
		else {
			str = "Hits:" + numHits.ToString() + "\nYour best:" +
			bestScore;
			if (bestScore > lastBest) str += "\nNEW RECORD!";
		}
		hitCount.text = str;
		
		// Instructions for losing
		if (transform.position.y < -3) {
			if (!hasLost) {
				hasLost = true;
				lastBest = bestScore;
				if (numHits > bestScore) {
					bestScore = numHits;
				}
			}
		}
	}
	
	void OnGUI() {
		if (hasLost) {
			float buttonW = 100f; // button width
			float buttonH = 50f; // button height
			float halfScreenW = Screen.width/2; // half of the Screen width
			float halfButtonW = buttonW/2; // Half of the button width
			
			if (GUI.Button(new Rect(halfScreenW - halfButtonW - 55, Screen.height * 0.8f,
				buttonW, buttonH), "Play Again"))
			{
				numHits = 0;
				hasLost = false;
				transform.position = new Vector3(0.5f, 2f, -0.05f);
				rigidbody.velocity = new Vector3(0,0,0);
			}
			
			// Back to Title
			if (GUI.Button(new Rect(halfScreenW - halfButtonW + 55, Screen.height * 0.8f,
				buttonW, buttonH), "Back"))
			{
				Application.LoadLevel("Title");
			}
		}
	}
}
