using UnityEngine;
using System.Collections;

public class PlatformSwing2 : MonoBehaviour {
	public float speed;
	public float totalTime;
	public float powerNumber;


	private int counter = 0;
	private float startTime;
	Vector3 pos;
	Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = pos = transform.position;
		startTime = totalTime;

	}
	
	// Update is called once per frame
	void Update () {
		totalTime -= Time.deltaTime;

		//states
		if((startTime > totalTime) && (totalTime >= startTime/2)) {
			counter = 1;
		}
		else if((startTime/2 > totalTime) && (totalTime >= 0)) {
			counter = 2;
		}
		else if((0 > totalTime) && (totalTime >= -1.0f * startTime/2)) {
			counter = 3;
		}
		else if((-1.0f * startTime/2 > totalTime) && (totalTime >= -1.0f * startTime)) {
			counter = 4;
		}
		else {
			totalTime = startTime;
			pos = startPos;
		}

		// movements
		Move (counter);

	//	Debug.Log ("total time " + totalTime);
	//	Debug.Log ("counter " + counter);
	}

	private float nSquare(float n) {
		return Mathf.Pow (n,powerNumber);
	}
	private void Move(int counter) {
		switch (counter) {
			case 1:
				pos.x -= nSquare (speed);
				pos.y -= nSquare (speed);
				transform.position = pos;
				break;
			case 2:
				pos.x -= nSquare (speed);
				pos.y += nSquare (speed);
				transform.position = pos;
				break;
			case 3:
				pos.x += nSquare (speed);
				pos.y -= nSquare (speed);
				transform.position = pos;
				break;
			case 4:
				pos.x += nSquare (speed);
				pos.y += nSquare (speed);
				transform.position = pos;
				break;
		}
	}
}
