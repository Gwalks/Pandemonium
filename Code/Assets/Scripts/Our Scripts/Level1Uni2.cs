using UnityEngine;
using System.Collections;

public class Level1Uni2 : MonoBehaviour {

	// Use this for initialization
	private GameObject player;
	private GameObject particles;
	private bool teleStarted = true;
	private float teleportLag = 3.0f;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		player.SetActive(false);
		particles = GameObject.FindGameObjectWithTag("TransportParticles");
	}
	
	// Update is called once per frame
	void Update () {
		if (teleStarted) {
			teleportLag -= Time.deltaTime;
		}
		if (teleportLag <= 0) {
			player.SetActive(true);
			Destroy(particles);
		}
	
	}
}
