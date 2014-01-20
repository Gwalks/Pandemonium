using UnityEngine;
using System.Collections;

public class Level1Uni2 : MonoBehaviour {

	// Use this for initialization
	private GameObject player;
	private GameObject particles;
	private GameObject camera;
	private bool teleStarted = true;
	private float teleportLag = 4.0f;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		player.SetActive(false);
		particles = GameObject.FindGameObjectWithTag("TransportParticles");
		camera = GameObject.FindGameObjectWithTag("MainCamera");
		camera.GetComponent<MoveCamera>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (teleStarted) {
			teleportLag -= Time.deltaTime;
		}
		if (teleportLag <= 0) {
			player.SetActive(true);
			Destroy(particles);
			camera.GetComponent<MoveCamera>().enabled = true;
		}
		if (Input.GetKeyUp(KeyCode.Escape))
			Application.LoadLevel("Start");
	
	}
}
