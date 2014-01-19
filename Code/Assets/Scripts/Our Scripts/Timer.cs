using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	//set position manually to correct location 
	//(0.5,0.5) refers to middle of screen
	float time = 10.0f;
	int t = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		time -= Time.deltaTime;
		t = (int)time;

		guiText.text = t.ToString();

		if(time<0)
		{
			time = 10.0f;
		}

	}
}
