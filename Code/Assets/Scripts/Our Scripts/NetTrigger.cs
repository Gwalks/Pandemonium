using UnityEngine;
using System.Collections;

public class NetTrigger : MonoBehaviour {
	
	// Use this for initialization
	public GameObject net;
	public float speedOfFallingNet = 10;
	public bool activated = false;
	void Start () {
	}

	public void setActivatedFalse() {
		activated = false;
	}

	public void setActivatedTrue() {
		activated = true;
	}
	// Update is called once per frame
	void Update () {
		if (activated) {
			Vector3 temp = net.transform.position;
			temp.y -= (speedOfFallingNet * Time.deltaTime);
			net.transform.position = temp;
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			activated = true;
			Debug.Log("Hit");
		}
		/*if (other.tag == "Ground") {
			activated = false;
		}*/
	}
}