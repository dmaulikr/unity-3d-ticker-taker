using UnityEngine;
using System.Collections;

public class InstructionsGUI : MonoBehaviour {
	public GUISkin customSkin;
	public GUIText instructions;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		int buttonW = 100;
		int buttonH = 50;
		float halfScreenW = Screen.width/2;
		float moveH = 420;
		float moveW = 90f;
		
		GUI.skin = customSkin;
		if(GUI.Button(new Rect(halfScreenW + moveW, moveH,buttonW,buttonH),"Back")) {
			//print("You clicked me!");
			Application.LoadLevel("Title");
		}
		
		// Instructions Text
		instructions.text = "Instructions: \n" +
			"You need to bounce \nthe heart with the book. \n" + 
			"You could think this \nhave no sense, but the \n" + 
			"heart need all the \nknowledge of that book \n" + 
			"to be able to survive. \n" + 
			"So, let's start the bouncing!";
	}
}
