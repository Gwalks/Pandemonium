using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	Vector3 position;
	// Use this for initialization
	public float speed;

	private string nextLevel = "GameOver";
	Vector3 playerPosition;
	Vector3 screenPos;

	private float xPlayer;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//move the camera
		position = transform.position;
		position.x += speed;
		transform.position = position;

		//calculate 
		playerPosition = GameObject.FindGameObjectWithTag ("Player").transform.position;
		// get the position from camera to screen position
		screenPos = Camera.main.WorldToScreenPoint (playerPosition);

		// change the value between 0 to 1
		//	Debug.Log ("player postion " + screenPos);

		if (screenPos.x < 0) {
			Application.LoadLevel(nextLevel);
			//Debug.Log ("game over");
		}
	}
}
