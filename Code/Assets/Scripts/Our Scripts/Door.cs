using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public GameObject level;
	public int doorNum;
	public int sceneNumber;
	
	public Door(int num)
	{
		doorNum = num;
	}

	public int GetDoorNum()
	{
		return doorNum;
	}

	void OnTriggerStay2D(Collider2D col)
	{
		/*if( col.gameObject.tag == "Player" && level.GetComponent<Level1Uni1>().CheckDoor(doorNum))
		{
			gameObject.active = false; 
		}*/
		if (col.gameObject.tag == "Player" && Input.GetKeyUp(KeyCode.E)) {
			Application.LoadLevel(sceneNumber);
		}

	}


	
}
