using UnityEngine;
using System.Collections;

public class BackToMain : MonoBehaviour {

	void OnGUI()
	{
		GUI.Label(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "1-985-655-2500");
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return))
		{
			Application.LoadLevel("Start");
		}
	}
}
