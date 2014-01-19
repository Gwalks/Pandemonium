using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed;
	Vector2 temp;
	GameObject level;


	// Use this for initialization
	void Start () {
		temp = rigidbody2D.velocity;
		temp.x = speed;
		rigidbody2D.velocity = temp;

		level = GameObject.FindGameObjectWithTag("Level");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Player")
		{
			Debug.Log ("You've been hit!");
			level.SendMessage("EndGame");
		}
	}
}
