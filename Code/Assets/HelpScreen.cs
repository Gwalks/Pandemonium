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
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		string backText = "Back";
		GUI.SetNextControlName(backText);
		bool backButton = GUI.Button(new Rect((Screen.width*5)/8,70,350,50),backText);

		if (Input.GetKeyUp(KeyCode.Return))
			backButton = true;

		if (backButton) {
			helpScreen.SetActive(false);
			mainScreen.SetActive(true);
			this.GetComponent<GameStartup>().enabled = true;
			this.enabled = false;
		}

		GUI.FocusControl(backText);

	}
}
