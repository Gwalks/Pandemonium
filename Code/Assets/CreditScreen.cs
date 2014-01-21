using UnityEngine;
using System.Collections;

public class CreditScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		string backText = "Back";
		GUI.SetNextControlName(backText);
		bool backButton = GUI.Button(new Rect((Screen.width*5)/8,(Screen.height*7)/8,350,50),backText);
		
		if (Input.GetKeyUp(KeyCode.Return))
			backButton = true;
		
		if (backButton) {
			Application.LoadLevel("Start");
		}
		
		GUI.FocusControl(backText);
	}
}
