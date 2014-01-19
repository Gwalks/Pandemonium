using UnityEngine;
using System.Collections;

public class PlatformSwing : MonoBehaviour {
	private float xpos;
	private float ypos;
	private float startTime;
	private int counter = 0;
	public float totalTime;

	public float speed;
	private int direction;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		xpos = transform.position.x;
		ypos = transform.position.y;
		pos = transform.position;
		startTime = totalTime;
	}
	
	// Update is called once per frame
	void Update () {

		totalTime -= Time.deltaTime;
		Debug.Log (totalTime);

		if ((startTime > totalTime) && (2f* startTime/3 <= totalTime )) {
			direction = 1;
		}
		else if ((2f *startTime/3 > totalTime) && (startTime/3 <= totalTime)) {
			direction = 2;
		}
		else if ((startTime/3 > totalTime) && (0 <= totalTime 	)) {
			direction = 3;
		}
		else {
			totalTime = startTime;
			counter++;
		}

		if ((direction == 1) && (counter % 2 == 0)) {
			pos.y -= speed;
			pos.x += speed;
			transform.position = pos;
		}
		else if ((direction == 2) && (counter % 2 == 0)) {
			pos.x += speed;
			transform.position = pos;
		}
		else if ((direction == 3) && (counter % 2 == 0)) {
			pos.y += speed;
			pos.x += speed;
			transform.position = pos;
		}
		else if ((direction == 1) && (counter % 2 == 1)) {
			pos.y -= speed;
			pos.x -= speed;
			transform.position = pos;
		}
		else if ((direction == 2) && (counter % 2 == 1)) {
			pos.x -= speed;
			transform.position = pos;
		}
		else if ((direction == 3) && (counter % 2 == 1)) {
			pos.x -= speed;
			pos.y += speed;
			transform.position = pos;
		}

		//reset counter
		if(counter == 25) {
			counter =0;
		}
	}
}
