using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	Vector3 position;
	// Use this for initialization
	public float speed;

	Vector3 playerPosition;
	Vector3 updatePlayer;
	Vector3 screenPos;

	private float xPlayer;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		position = transform.position;
		position.x += speed;
		transform.position = position;

		playerPosition = GameObject.FindGameObjectWithTag ("Player").transform.position;
		screenPos = Camera.main.WorldToScreenPoint (playerPosition);

		// change the value between 0 to 1
	//	Debug.Log ("player postion " + screenPos);

		if (screenPos.x < 0) {
			Debug.Log ("game over");
		}
		//if (transform.position.x > playerPosition.x) {

	}
}
