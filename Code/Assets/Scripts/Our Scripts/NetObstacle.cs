using UnityEngine;
using System.Collections;

public class NetObstacle : MonoBehaviour {

	// Use this for initialization
	private bool caught = false;
	private Vector2 currentVelocity;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (caught) {
			if (Input.GetKeyUp(KeyCode.Space)) {

			}
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			caught = true;
		}
		if (caught) {
			currentVelocity = other.rigidbody2D.velocity;
			Vector2 temp = Vector2.zero;
			other.rigidbody2D.velocity = temp;
		}
		/*if (other.tag == "Ground") {
			activated = false;
		}*/
	}
}
