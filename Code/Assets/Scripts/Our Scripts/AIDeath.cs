using UnityEngine;
using System.Collections;

public class AIDeath : MonoBehaviour {

	GameObject enemy;

	void Start()
	{
		enemy = transform.parent.gameObject;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
			enemy.gameObject.active = false;
	}
}
