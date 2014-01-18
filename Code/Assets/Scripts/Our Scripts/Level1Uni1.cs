using UnityEngine;
using System.Collections;

public class Level1Uni1 : MonoBehaviour {

	Inventory i;
	public int numOfKeys;
	
	// Use this for initialization
	void Start () {
		i = new Inventory(numOfKeys);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void AddKey(int keyNum)
	{
		i.AddKey(keyNum);
	}

	void CheckDoor(int doorNum)
	{
		if(i.CheckIfHaveKey(doorNum))
		{
			Debug.Log ("OpenedDoor");
		}
	}


}
