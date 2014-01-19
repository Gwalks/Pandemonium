using UnityEngine;
using System.Collections;

public class AISight : MonoBehaviour {

	public GameObject bullet;
	Vector2 spawnPlace;
	bool seenPlayer;


	void Start()
	{

	}

	void Update()
	{
		spawnPlace = this.gameObject.transform.position;
	}

	void SpawnBullet()
	{
		Instantiate(bullet, spawnPlace, Quaternion.identity);
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
