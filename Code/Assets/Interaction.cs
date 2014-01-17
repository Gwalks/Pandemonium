using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

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
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
