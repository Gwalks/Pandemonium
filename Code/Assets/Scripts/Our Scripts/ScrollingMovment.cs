using UnityEngine;
using System.Collections;


public class ScrollingMovment : MonoBehaviour {
	
	KeyCode leftKey;
	KeyCode rightKey;
	KeyCode jump;
	public bool facingRight = true;
	public float speed = 10;
	public int jumpSpeed = 10;
	bool isGrounded;
	private bool keyboardEnable = true;
	Animator anim;
	public AudioClip jumpClip;
	public AudioClip tele;
	bool teleporting;
	
	// Use this for initialization
	void Start () {
		audio.volume = 1.0f;
		anim = GetComponent<Animator>();
		isGrounded = true;
		leftKey = KeyCode.A;
		rightKey = KeyCode.D;
		jump = KeyCode.Space;
		teleporting = false;
	}
	
	public void setKeyboardEnableFalse() {
		keyboardEnable = false;
	}
	
	public void setKeyboardEnableTrue() {
		keyboardEnable = true;
	}
	// Update is called once per frame
	void Update () {
		anim.SetInteger("WalkTransition",0);
		float h = Input.GetAxis("Horizontal");
		if (keyboardEnable) 
		{
			if(isGrounded && !teleporting)
			{
				if (Input.GetKey(leftKey)) 
				{
					anim.SetInteger("WalkTransition",1);
					Vector2 temp = rigidbody2D.velocity;
					temp.x = speed*-1;
					rigidbody2D.velocity = temp;
				}
				if (Input.GetKey(rightKey)) 
				{
					anim.SetInteger("WalkTransition",1);
					Vector2 temp = rigidbody2D.velocity;
					temp.x = speed;
					rigidbody2D.velocity = temp;
				}
				if(Input.GetKeyDown(jump))
				{
					audio.PlayOneShot(jumpClip);
					anim.SetInteger("WalkTransition",2);
					Vector2 temp = rigidbody2D.velocity;
					temp.y = jumpSpeed;
					rigidbody2D.velocity = temp;
					isGrounded = false;
				}
				if (Input.GetKeyUp(jump) || Input.GetKeyUp(rightKey) || Input.GetKeyUp(leftKey))
				{
					audio.PlayOneShot(jumpClip);
					anim.SetInteger("WalkTransition",2);
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
				if(h > 0 && !facingRight)
					// ... flip the player.
					Flip();
				// Otherwise if the input is moving the player left and the player is facing right...
				else if(h < 0 && facingRight)
					// ... flip the player.
					Flip();
				
			}
			
			//if(rigidbody2D.velocity.y != 0.0f)
			//	isGrounded = false;
			
			if(rigidbody2D.velocity.y == 0.0f)
			{
				isGrounded = true;
			}
			else{
				anim.SetInteger("WalkTransition",2);
			}
			//Debug.Log(rigidbody2D.velocity.y.ToString());
		}
	}
	
	void Flip() {
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	void OnCollisionStay2D(Collision2D other) {
		float h = Input.GetAxis("Horizontal");
		if (other.gameObject.tag == "Obstacle" && h != 0) {
			Vector2 temp = rigidbody2D.velocity;
			temp.y = -10;
			temp.x = 0;
			rigidbody2D.velocity = temp;
			isGrounded = true;
			keyboardEnable = false;
			
		}
		//Debug.Log(z);
	}
	
	public void IsTelePorting()
	{
		audio.PlayOneShot(tele);
		teleporting = true;
	}
	
}