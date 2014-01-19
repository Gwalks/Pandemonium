using UnityEngine;
using System.Collections;

public class TextBox : MonoBehaviour {

	private Vector2 guiTextBoxLoc = new Vector2(0,(Screen.height * 6)/8);
	public string[] text = new string[]{"Hi","Bacon","NYAH"};
	private int textIndex = 0;
	private bool showText = false;
	private float bufferSeconds = 1.0f;

	void OnGUI() {
		if (showText && textIndex != text.Length){
			GUI.Box(new Rect(guiTextBoxLoc.x,guiTextBoxLoc.y,Screen.width,Screen.height/8),text[textIndex]);
		}
		if(textIndex >= text.Length)
			GameObject.FindGameObjectWithTag("Level").GetComponent<Level1Uni1>().UnPauseTimer();
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (showText) {
			if (bufferSeconds <= 0.0f)
				if (Input.GetKeyUp(KeyCode.E))
					textIndex++;
			bufferSeconds -= Time.deltaTime;
		}
		/*if (showText)
			bufferSeconds -= Time.deltaTime;*/
		Debug.Log(textIndex);
	}

	void OnTriggerStay2D(Collider2D other) {
		//Debug.Log ("Bacon");
		if (Input.GetKeyUp(KeyCode.E) && other.gameObject.tag == "Player") {
			showText = true;
			Debug.Log ("Bacon");
			GameObject.FindGameObjectWithTag("Level").GetComponent<Level1Uni1>().PauseTimer();
		}

	}

	void OnTriggerExit2D(Collider2D col)
	{
		GameObject.FindGameObjectWithTag("Level").GetComponent<Level1Uni1>().UnPauseTimer();
		showText = false;

	}

}
