using UnityEngine;
using System.Collections;


public class Movment : MonoBehaviour {

	public KeyCode leftKey;
	public KeyCode rightKey;
	public KeyCode jump;
	public float speed = 10;
	public int jumpSpeed = 10;
	bool isGrounded;

	public Level1Uni1 level1;

	// Use this for initialization
	void Start () {
		isGrounded = true;
		leftKey = KeyCode.A;
		rightKey = KeyCode.D;
		jump = KeyCode.Space;
	}
	
	// Update is called once per frame
	void Update () {
		if(isGrounded)
		{
			if (Input.GetKey(leftKey)) 
			{
				//rigidbody2D.velocity.x = speed*-1;
				Vector2 temp = rigidbody2D.velocity;
				temp.x = speed*-1;
				rigidbody2D.velocity = temp;
			}
			if (Input.GetKey(rightKey)) 
			{
				//rigidbody2D.velocity.x = speed;
				Vector2 temp = rigidbody2D.velocity;
				temp.x = speed;
				rigidbody2D.velocity = temp;
			}
			if(Input.GetKeyDown(jump))
			{
				Vector2 temp = rigidbody2D.velocity;
				temp.y = jumpSpeed;
				rigidbody2D.velocity = temp;
				isGrounded = false;
			}
			if (Input.GetKeyUp(jump) || Input.GetKeyUp(rightKey) || Input.GetKeyUp(leftKey))
			{
				Vector2 temp = rigidbody2D.velocity;
				temp.x = speed*0;
				rigidbody2D.velocity = temp;
			}

		}

		if(rigidbody2D.velocity.y ==0)
		{
			isGrounded = true;
		}
		//Debug.Log(rigidbody2D.velocity.y.ToString());
	}

}
