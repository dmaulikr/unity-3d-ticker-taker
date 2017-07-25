using UnityEngine;
using System.Collections;

public class DisappearMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update() {
        int seconds = (int)Time.time;
        bool oddeven = seconds % 2 == 0;
        renderer.enabled = oddeven;
    }
	
    public void Awake() {
        renderer.enabled = true;
    }
}
