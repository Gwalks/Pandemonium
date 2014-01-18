using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

	public GameObject level;

	void OnCollisionStay2D(Collision2D other)
	{
		if(Input.GetKey(KeyCode.E) && other.collider.tag == "Player")
		{
			renderer.material.color = Color.red;
		}
	}

	void OnCollisionExit(Collision Other)
	{
	}

	void OnTriggerStay2D(Collider2D col ) 
	{
		if (Input.GetKey(KeyCode.E) && col.tag == "Player")
		{
			level.SendMessage("AddKey", gameObject.GetComponent<Key>().GetKeyNum());
		}
	}

}
