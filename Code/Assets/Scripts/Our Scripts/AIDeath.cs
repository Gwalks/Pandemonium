using UnityEngine;
using System.Collections;

public class AIDeath : MonoBehaviour {
	
	class Key
	{	
		int keyNum;
		public Key(int num)
		{
			keyNum = num;
		}
		
		public int GetKeyNum()
		{
			return keyNum;
		}
	}

	public int keyNum;
	public GameObject level;

	Key k;

	public bool hasKey;
	GameObject enemy;

	void Start()
	{
		if(hasKey)
		{
			k = new Key(keyNum);
		}
		enemy = transform.parent.gameObject;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			if(hasKey)
			{
				level.SendMessage("AddKey", k.GetKeyNum());
			}
			enemy.gameObject.active = false;
		}
	}
}
