using UnityEngine;
using System.Collections;

public class GameStartup : MonoBehaviour {

	// Use this for initialization
	//public GUITexture menuScreen;
	private string [] buttonNames= {"Play","Help","Credits","Exit"};
	private bool[] buttons;
	private GameObject helpTexture;
	private GameObject mainScreen;
	private bool helpActive = false;
	private bool exitActive = false;
	int currentSelection = 0;
	void Awake() {
		Screen.SetResolution(1024,768,true);
		//menuScreen = this.gameObject.GetComponent("GUITexture") as GUITexture;
	}

	void Start () {
		buttons = new bool[buttonNames.Length];
		helpTexture = GameObject.Find("HelpScreen");
		mainScreen = GameObject.Find("MainMenu");
		//helpTexture.SetActive(false);
		/*int textureWidth = menuScreen.texture.width;
		int textureHeight = menuScreen.texture.height;
		int screenWidth = Screen.width;
		int screenHeight = Screen.height;

		int screenAspectRatio = (screenWidth/screenHeight);
		int textureAspectRatio = (textureWidth/textureHeight);

		int scaledHeight;
		int scaledWidth;
		if (textureAspectRatio <= screenAspectRatio) 
		{
			scaledHeight = screenHeight;
			scaledWidth = (screenHeight * textureAspectRatio);
		}
		else 
		{
			scaledWidth = screenWidth;
			scaledHeight = (scaledWidth / textureAspectRatio);
		}
		float xPostion = screenWidth / 2 - (scaledWidth/2);
		menuScreen.pixelInset = new Rect(xPostion, scaledHeight - scaledHeight,scaledWidth,scaledHeight);*/
	}

	void OnGUI()
	{

		if (!helpActive && !exitActive) {
			for (int i = 0; i < buttonNames.Length; i++) 
			{
				GUI.SetNextControlName(buttonNames[i]);
				//buttons[i] = GUI.Button(new Rect(Screen.width - 100,70 + (20 * i), 80, 20),buttonNames[i]);
				buttons[i] = GUI.Button(new Rect((Screen.width*5)/8,70 + (60 * i), 350, 50),buttonNames[i]);
			}
			if (Input.GetKeyUp(KeyCode.Return)) {
				buttons[currentSelection] = true;
			}
			
			if (buttons[0]) {
				Application.LoadLevel("Story");
			}
			if (buttons[1]) {
				Debug.Log("Second button pressed");
				Application.LoadLevel("HelpScreen");
			}
			if (buttons[2]) {
				Debug.Log("Third button pressed");
				Application.LoadLevel("CreditsScreen");
			}
			if (buttons[3]) {
				Application.Quit();
			}
			Debug.Log(currentSelection);
			GUI.FocusControl(buttonNames[currentSelection]);
		}
	}

	// Update is called once per frame
	void Update () {
		if (!helpActive && !exitActive) {
			if (Input.GetKeyUp(KeyCode.S)) {
				if (currentSelection < buttons.Length-1) {
					currentSelection++;
				}
				else 
					currentSelection = buttons.Length-1;
			}
			if (Input.GetKeyUp(KeyCode.W)) {
				if (currentSelection > 0) {
					currentSelection--;
				}
				else {
					currentSelection = 0;
				}
			}
		}
	}
}
