using UnityEngine;
using System.Collections;

public class TitleGUI : MonoBehaviour {
	public GUISkin customSkin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		int buttonW = 100;
		int buttonH = 50;
		float halfScreenW = Screen.width/2;
		float moveW = 200f;
		
		GUI.skin = customSkin;
		if(GUI.Button(new Rect(halfScreenW - moveW,250,buttonW,buttonH),"Play Game")) {
			//print("You clicked me!");
			Application.LoadLevel("Game");
		}
		
		if(GUI.Button(new Rect(halfScreenW - moveW + 10 + buttonW,250,buttonW,buttonH),"Credits")) {
			Application.LoadLevel("credits");
		}
		
		if(GUI.Button(new Rect(halfScreenW - moveW + 10 + buttonW,260 + buttonH,buttonW,buttonH),"Instructions")) {
			Application.LoadLevel("instructions");
		}
	}
}
