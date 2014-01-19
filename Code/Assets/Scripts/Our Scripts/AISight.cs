using UnityEngine;
using System.Collections;

public class AISight : MonoBehaviour {

	public Rigidbody2D bullet;
	Vector2 spawnPlace;
	bool seenPlayer;

	public float bulletSpeed;

	void Start()
	{

	}

	void Update()
	{
		spawnPlace = this.gameObject.transform.position;

	}

	void SpawnBullet()
	{
		Rigidbody2D clone = (Rigidbody2D) Instantiate(bullet, transform.position, Quaternion.identity);
		clone.velocity = Vector2.right * bulletSpeed * (int)transform.GetComponent<AIMovement>().GetDirection();

		Debug.Log(clone.velocity + ": " + (int)transform.GetComponent<AIMovement>().GetDirection() );

	}

	void OnTriggerEnter2D( Collider2D col)
	{
		if(col.tag == "Player")
		{
			Debug.Log ("You've been spotted!");
			SpawnBullet ();
		}

	}
}
