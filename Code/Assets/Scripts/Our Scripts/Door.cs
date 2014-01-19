using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public GameObject level;
	public int doorNum;
	
	public Door(int num)
	{
		doorNum = num;
	}

	public int GetDoorNum()
	{
		return doorNum;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if( col.gameObject.name == "player" && level.GetComponent<Level1Uni1>().CheckDoor(doorNum))
		{

			gameObject.active = false; 
		}
	}


	
}
