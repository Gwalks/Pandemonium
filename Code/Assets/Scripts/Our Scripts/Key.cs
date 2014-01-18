using UnityEngine;
using System.Collections;


public class Key : MonoBehaviour {
	
	public int keyNum;
	public GameObject level;

	public Key(int num)
	{
		keyNum = num;
	}

	public int GetKeyNum()
	{
		return keyNum;
	}

	void OnTriggerStay2D(Collider2D col ) 
	{
		if (Input.GetKey(KeyCode.E) && col.tag == "Player")
		{
			level.SendMessage("AddKey", gameObject.GetComponent<Key>().GetKeyNum());
			gameObject.active = false;
		}
	}
}
