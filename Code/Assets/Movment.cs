using UnityEngine;
using System.Collections;

public class Movment : MonoBehaviour {

	public KeyCode leftKey;
	public KeyCode rightKey;
	public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(leftKey)) 
		{
			//rigidbody2D.velocity.x = speed*-1;
			Vector2 temp = rigidbody2D.velocity;
			temp.x = speed*-1;
			rigidbody2D.velocity = temp;
		}
		else if (Input.GetKey(rightKey)) 
		{
			//rigidbody2D.velocity.x = speed;
			Vector2 temp = rigidbody2D.velocity;
			temp.x = speed;
			rigidbody2D.velocity = temp;
		}
		else 
		{
			Vector2 temp = rigidbody2D.velocity;
			temp.x = speed*0;
			rigidbody2D.velocity = temp;
		}

	}
}
