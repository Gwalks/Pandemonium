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
	/*void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			renderer.material.color = Color.red;
		}
	}*/
	void OnCollisionExit(Collision Other)
	{
	}

	void OnTriggerStay2D(Collider2D col ) 
	{
		if (Input.GetKey(KeyCode.E) && col.tag == "Player")
		{
			level.GetComponent<Level1Uni1>().ChangeKeyValue();
			Debug.Log ("You picked that shit up!");
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
