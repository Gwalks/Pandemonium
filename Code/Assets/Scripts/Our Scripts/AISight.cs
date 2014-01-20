using UnityEngine;
using System.Collections;

public class AISight : MonoBehaviour {

	public Rigidbody2D bullet;
	Vector2 spawnPlace;
	bool seenPlayer;
	Animator anim;
	public float bulletSpeed;

	void Start()
	{
		anim = transform.parent.GetComponent<Animator>();
	}

	void Update()
	{
		spawnPlace = this.gameObject.transform.position;

	}

	void SpawnBullet()
	{
		anim.SetInteger("Transition",3);
		Rigidbody2D clone = (Rigidbody2D) Instantiate(bullet, transform.position, Quaternion.identity);
		clone.velocity = Vector2.right * bulletSpeed * (int)transform.parent.GetComponent<AIMovement>().GetDirection();
		
	}

	void OnTriggerEnter2D( Collider2D col)
	{
		if(col.tag == "Player")
		{
			anim.SetInteger("Transition", 2);
			Debug.Log ("You've been spotted!");
			SpawnBullet ();
		}

	}
}
