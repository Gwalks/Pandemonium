using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	Key[] keys;
	int numOfKeysCollected;

	public Inventory(int numKeysInLevel)
	{
		keys = new Key[numKeysInLevel];
		numOfKeysCollected = 0;
	}

	public void AddKey(int keyNum)
	{
		keys[numOfKeysCollected] = new Key(keyNum);
		numOfKeysCollected++;
		Debug.Log(keyNum);
	}

	public bool CheckIfHaveKey(int doorNumber)
	{
		for(int i = 0; i < numOfKeysCollected; i++)
		{
			Debug.Log("boop2");
			if(keys[i].GetKeyNum() == doorNumber)
				return true;
		}
		return false;
	}


}
