using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public AudioClip doorOpen;
	public AudioClip doorLocked;
	public GameObject level;
	public int doorNum;
	public string nextLevel;
	
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
			audio.PlayOneShot(doorOpen);
			Application.LoadLevel(nextLevel);
		}

	}


	
}
