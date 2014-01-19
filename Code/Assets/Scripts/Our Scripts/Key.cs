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

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			level.SendMessage("AddKey", gameObject.GetComponent<Key>().GetKeyNum());
			gameObject.active = false;
		}
	}
}
