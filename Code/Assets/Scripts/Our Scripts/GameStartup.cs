using UnityEngine;
using System.Collections;

public class GameStartup : MonoBehaviour {

	// Use this for initialization
	//public GUITexture menuScreen;
	private string [] buttonNames= {"Play","Help","Exit","Back"};
	private bool[] buttons;
	private GameObject helpTexture;
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
		if (helpActive) {
			/*GUI.SetNextControlName(buttonNames[3]);
			buttons[3] = GUI.Button (new Rect((Screen.width*5)/8,250,350,50),buttonNames[3]);
			
			if (Input.GetKeyUp(KeyCode.Return)) {
				Vector3 temp = helpTexture.transform.position;
				temp.z = 0;
				helpTexture.transform.position = temp;
				helpActive = false;
				buttons[3] = false;
			}
			
			if (buttons[3]) {
				Vector3 temp = helpTexture.transform.position;
				temp.z = 0;
				helpTexture.transform.position = temp;
				helpActive = false;
				Debug.Log("GOBACK");
				buttons[3] = false;
			}
			GUI.FocusControl(buttonNames[3]);*/
		}

		if (!helpActive && !exitActive) {
			for (int i = 0; i < buttonNames.Length - 1; i++) 
			{
				GUI.SetNextControlName(buttonNames[i]);
				//buttons[i] = GUI.Button(new Rect(Screen.width - 100,70 + (20 * i), 80, 20),buttonNames[i]);
				buttons[i] = GUI.Button(new Rect((Screen.width*5)/8,70 + (60 * i), 350, 50),buttonNames[i]);
			}
			if (Input.GetKeyUp(KeyCode.Return)) {
				buttons[currentSelection] = true;
			}
			
			if (buttons[0]) {
				Application.LoadLevel(1);
			}
			if (buttons[1]) {
				Debug.Log("Second button pressed");
				helpActive = true;
				Vector3 temp = helpTexture.transform.position;
				temp.z = 1;
				helpTexture.transform.position = temp;
			}
			if (buttons[2]) {
				Debug.Log("Third button pressed");
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
