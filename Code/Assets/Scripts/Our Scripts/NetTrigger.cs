using UnityEngine;
using System.Collections;

public class NetTrigger : MonoBehaviour {
	
	// Use this for initialization
	public GameObject net;
	public float speedOfFallingNet = 10;
	private bool activated = false;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (activated == true) {
			Vector3 temp = net.transform.position;
			temp.y -= (speedOfFallingNet * Time.deltaTime);
			net.transform.position = temp;
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (!activated)
		if (other.tag == "Player") {
			activated = true;
			Debug.Log("Hit");
		}
		/*if (other.tag == "Ground") {
			activated = false;
		}*/
	}
}