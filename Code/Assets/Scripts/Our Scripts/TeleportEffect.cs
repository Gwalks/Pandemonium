using UnityEngine;
using System.Collections;

public class TeleportEffect : MonoBehaviour {

	GameObject level;
	bool teleStarted = false;
	public float teleportLag;

	// Use this for initialization
	void Start () {
		level = GameObject.FindGameObjectWithTag("Level");
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
			teleStarted = true;
			transform.parent.GetComponent<Movment>().IsTelePorting();
		}
		if(teleportLag <= 0)
		{
			level.SendMessage("ChangeLevel");
		}
	}
}
