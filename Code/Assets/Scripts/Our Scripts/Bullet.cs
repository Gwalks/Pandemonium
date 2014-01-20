using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed;
	Vector2 temp;
	GameObject level;


	// Use this for initialization
	void Start () {

		level = GameObject.FindGameObjectWithTag("Level");
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 2.0f);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Player")
		{
			Debug.Log ("You've been hit!");
			level.SendMessage("LoseGame");
		}
	}

	public void Flip() {

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
