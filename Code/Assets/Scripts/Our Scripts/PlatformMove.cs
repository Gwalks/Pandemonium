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
		Debug.Log (position.x);
		Debug.Log (position.y);
		if(vert) { //vertical direction
			if (max) {
				position.y -= speed;
				transform.position = position;
			}
			else {
				position.y += speed;
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
		if(vert) {
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
