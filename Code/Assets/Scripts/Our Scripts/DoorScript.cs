using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	bool hasHit;

	// Use this for initialization
	void Start () {
		hasHit = false;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if( col.gameObject.name == "player")
		{
			hasHit = true;
		}
	}

	void OnCollisionExit2D(Collision2D collision)
	{
		hasHit = false;
	}

	public bool CheckCollider()
	{
		return hasHit;
	}
}
