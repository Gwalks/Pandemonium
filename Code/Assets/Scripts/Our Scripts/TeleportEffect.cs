using UnityEngine;
using System.Collections;

public class TeleportEffect : MonoBehaviour {

	GameObject level;
	bool teleStarted = false;
	public float teleportLag;
	private GameObject particles;

	// Use this for initialization
	void Start () {
		level = GameObject.FindGameObjectWithTag("Level");
		//particles = GameObject.FindGameObjectWithTag("TransportParticles");
		//particles.SetActive(false);
		gameObject.particleSystem.Pause();
	}
	
	// Update is called once per frame
	void Update () {
		if(teleStarted)
		{
			teleportLag -= Time.deltaTime;
		}
		if(level.GetComponent<Level1Uni1>().GetTimer() <= 1.0)
		{
			gameObject.particleSystem.Play();
			//particles.SetActive(true);
			teleStarted = true;
			transform.parent.GetComponent<Movment>().IsTelePorting();
		}
		if(teleportLag <= 0)
		{
			level.SendMessage("ChangeLevel");
		}
	}
}
