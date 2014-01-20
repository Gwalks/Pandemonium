using UnityEngine;
using System.Collections;

public class NetObstacle : MonoBehaviour {

	// Use this for initialization
	private bool caught = false;
	private Vector2 currentVelocity;
	private GameObject player;
	private int count = 0;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (caught) {
			if (Input.GetKeyDown(KeyCode.Space) && count == 0) {
				player.GetComponent<Movment>().setKeyboardEnableTrue();
				NetTrigger temp2 = this.gameObject.GetComponentInChildren(typeof(NetTrigger)) as NetTrigger;
				temp2.setActivatedTrue();
				caught = false;
				count++;
			}
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player" && count == 0) {
			caught = true;
		}
		if (caught && count == 0) {
			currentVelocity = other.rigidbody2D.velocity;
			Vector2 temp = Vector2.zero;
			other.rigidbody2D.velocity = temp;
			other.GetComponent<Movment>().setKeyboardEnableFalse();
			player = other.gameObject;
			NetTrigger temp2 = this.gameObject.GetComponentInChildren(typeof(NetTrigger)) as NetTrigger;
			temp2.setActivatedFalse();
		}
	}

	void OnGUI() {
		if (caught && count == 0) {
			GUI.Box(new Rect(0,(Screen.height*6)/8,Screen.width,(Screen.height*8)/9),"Press Space To Escape!");
		}
	}
}
