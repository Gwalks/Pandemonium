using UnityEngine;
using System.Collections;

public class HelpScreen : MonoBehaviour {

	// Use this for initialization
	private GameObject helpScreen;
	private GameObject mainScreen;
	void Start () {
		helpScreen = GameObject.Find("HelpScreen");
		mainScreen = GameObject.Find("MainMenu");

	}

	void OnEnable() {
		helpScreen.SetActive(true);
	}

	void OnDisable() {
		helpScreen.SetActive(false);
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
