using UnityEngine;
using System.Collections;

public class PlatformMove : MonoBehaviour {
	private float xpos;
	private float ypos;
	public float speed;

	Vector3 position;
	public float maxAmount;
	private bool max;
	public bool vert;
	// Use this for initialization
	void Start () {
		xpos = transform.position.x;
		ypos = transform.position.y;
		position = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if(vert) { //vertical direction
			if (max) {
				position.y -= speed; // max = true = down
				transform.position = position;
			}
			else {
				position.y += speed; // max = true = up
				transform.position = position;
			}
		}
		else { //horizontal direction
			if (max) {
				position.x -= speed;
				transform.position = position;
			}
			else {
				position.x += speed;	
				transform.position = position;
			}
		}
		// check the range to set true or false in max
		if(vert && maxAmount > 0) {
			if(position.y >= ypos + maxAmount) {
				max = true;
			}
			else if (position.y <= ypos){
				max = false;
			}
		}
		else {
			if(position.x >= xpos + maxAmount) {
				max = true;
			}
			else if (position.x <= xpos) {
				max = false;
			}
		}
	}
}
