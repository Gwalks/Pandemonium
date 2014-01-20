using UnityEngine;
using System.Collections;

public class SlowCharacter : MonoBehaviour {

	public float slowFactor = 0.25f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			Vector2 temp = other.rigidbody2D.velocity;
			temp.x = slowFactor;
			other.rigidbody2D.velocity = temp;
			Debug.Log ("Slow");
		}
	}
}
