using UnityEngine;
using System.Collections;

public class CreditsGUI : MonoBehaviour {
	public GUISkin customSkin;
	public GUIText credits;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		int buttonW = 100;
		int buttonH = 50;
		float halfScreenW = Screen.width/2;
		float moveH = 530;
		float moveW = 250f;
		
		GUI.skin = customSkin;
		if(GUI.Button(new Rect(halfScreenW + moveW, moveH,buttonW,buttonH),"Back")) {
			//print("You clicked me!");
			Application.LoadLevel("Title");
		}
		
		// Instructions Text
		credits.text = "TickerTaker! v0.8 \n" +
			"Alejandro Saldarriaga Pérez \n" +
			"2011 ®";
	}
}
