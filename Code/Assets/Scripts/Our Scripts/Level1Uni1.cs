using UnityEngine;
using System.Collections;

public class Level1Uni1 : MonoBehaviour {

	bool hasKey1;
	public GameObject door1;


	// Use this for initialization
	void Start () {
		hasKey1 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if( hasKey1 && door1.GetComponent<DoorScript>().CheckCollider())
		{
			Debug.Log ("You Opened the Door!! Grats Bro!");
		}
	}
	

	public void ChangeKeyValue()
	{
		hasKey1 = true;
	}
}
