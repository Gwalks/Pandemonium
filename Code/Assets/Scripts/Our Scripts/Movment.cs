using UnityEngine;
using System.Collections;


public class Movment : MonoBehaviour {

	KeyCode leftKey;
	KeyCode rightKey;
	KeyCode jump;
	public bool facingRight = true;
	public float speed = 10;
	public int jumpSpeed = 10;
	bool isGrounded;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		isGrounded = true;
		leftKey = KeyCode.A;
		rightKey = KeyCode.D;
		jump = KeyCode.Space;
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetInteger("WalkTransition",0);
		float h = Input.GetAxis("Horizontal");
		if(isGrounded)
		{
			if (Input.GetKey(leftKey)) 
			{
				anim.SetInteger("WalkTransition",1);
				//rigidbody2D.velocity.x = speed*-1;
				Vector2 temp = rigidbody2D.velocity;
				temp.x = speed*-1;
				rigidbody2D.velocity = temp;
			}
			if (Input.GetKey(rightKey)) 
			{
				anim.SetInteger("WalkTransition",1);
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
			if (h > 0 && !facingRight) {
				Flip();
			}
			else if (h < 0 && facingRight) {
				Flip();
			}
		}

		if(rigidbody2D.velocity.y ==0)
		{
			isGrounded = true;
		}
		//Debug.Log(rigidbody2D.velocity.y.ToString());
	}

	void Flip() {
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
