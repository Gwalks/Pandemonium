using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	public string nextLevel;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Player")
		{
			Application.LoadLevel(nextLevel);
		}
	}
}
