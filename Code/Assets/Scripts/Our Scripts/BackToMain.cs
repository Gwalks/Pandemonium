using UnityEngine;
using System.Collections;

public class BackToMain : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return))
		{
			Application.LoadLevel("Start");
		}
	}
}
