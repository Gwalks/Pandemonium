using UnityEngine;
using System.Collections;

public class Level1Uni1 : MonoBehaviour {

	bool hasKey1;
	private bool paused = false;
	public GameObject door1;
	public GUIText numOfKeys;
	float time = 10.0f;
	// Use this for initialization
	void Start () {
		hasKey1 = false;
		//new Vector3(50.1f,35.1f,0)
		numOfKeys.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.1f,0.1f,0)); 
		numOfKeys.text = "testing";

 	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if( hasKey1 && door1.GetComponent<DoorScript>().CheckCollider())
		{
			Debug.Log ("You Opened the Door!! Grats Bro!");
		}
		if(time<0)
		{
			time = 10.0f;
		}
	}
	

	public void ChangeKeyValue()
	{
		hasKey1 = true;
	}


	public void OnGUI () {
		GUIStyle style = new GUIStyle ();
		style.fontSize = 20;
		GUI.Label (new Rect (Screen.width - 100, 0, 200, 50), time.ToString(),style );
		GUI.Label (new Rect (Screen.width - 200, 50, 200, 50), "Number of Keys", style);


	}
}
