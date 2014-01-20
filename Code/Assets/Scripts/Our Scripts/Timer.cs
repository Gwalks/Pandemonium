using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	//set position manually to correct location 
	//(0.5,0.5) refers to middle of screen
	public float levelTime;
	int t;
	float timer;

	// Use this for initialization
	void Start () {
		timer = levelTime;
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		t = (int)timer;

		guiText.text = t.ToString();

		if(timer<0)
		{
			//gameObject.transform.parent.GetComponent<Level1Uni1>().ChangeLevel();
		}

	}

	public void ResetTimer()
	{
		timer = levelTime;
	}



}
