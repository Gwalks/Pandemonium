using UnityEngine;
using System.Collections;

public class AIMovement : MonoBehaviour {

	public float pacingSpeed;
	Vector2 temp;
	
	public float timeToPace;
	public float timeToPause;
	public bool facingRight = true;
	bool pause;
	float paceTimer;
	float pauseTimer;

	public enum PacingDirection
	{
		left = -1,
		center = 0,
		right = 1
	}
	
	PacingDirection p = PacingDirection.right;
	
	// Use this for initialization
	void Start () {
		pause = false;
		paceTimer = timeToPace;
		pauseTimer = timeToPause;
	}
	
	// Update is called once per frame
	void Update () {
		//float h = Input.GetAxis("Horizontal");

		if(!pause)
		{
			paceTimer -= Time.deltaTime;
			MoveAI();
		}
		else
		{
			pauseTimer -= Time.deltaTime;
		}

		if(paceTimer <= 0)
		{
			ChangeDirection();
			paceTimer = timeToPace;
			pause = true;
		}
		if(pauseTimer <= 0)
		{
			PauseAI();
			pauseTimer = timeToPause;
			pause = false;
		}

		//if (p == PacingDirection.left && !facingRight)
		//	Flip();
		//else if (p == PacingDirection.right && facingRight)
		//	Flip();
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void ChangeDirection()
	{
		switch(p)
		{
		case PacingDirection.left:
			p = PacingDirection.right;
			break;
		case PacingDirection.right:
			p = PacingDirection.left;
			break;
		}
		if (p == PacingDirection.left)
			Flip();
		else if (p == PacingDirection.right)
			Flip();
	}

	void MoveAI()
	{
		temp = rigidbody2D.velocity;
		temp.x = (float)p * pacingSpeed;
		rigidbody2D.velocity = temp;
	}

	void PauseAI()
	{
		temp = rigidbody2D.velocity;
		temp.x = (float)PacingDirection.center * pacingSpeed;
		rigidbody2D.velocity = temp;
	}
}
