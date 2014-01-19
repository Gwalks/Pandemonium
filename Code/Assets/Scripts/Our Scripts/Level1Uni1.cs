using UnityEngine;
using System.Collections;

public class Level1Uni1 : MonoBehaviour {

	Inventory i;
	public int numOfKeys;
	public string levelName;
	public float levelTime;

	bool pauseTimer = false;
	
	// Use this for initialization
	void Start () {
		i = new Inventory(numOfKeys);
	}
	
	// Update is called once per frame
	void Update () {
		if(!pauseTimer)
			levelTime -= Time.deltaTime;
		if(levelTime <= 0)
		{
			ChangeLevel ();
		}
	}

	void OnGUI() {
		GUIStyle timeStyle = new GUIStyle();
		timeStyle.fontSize = 20;
		GUI.Label(new Rect(Screen.width - 100,0,50,25),"Time: " + (int)levelTime,timeStyle);
	}
	public void AddKey(int keyNum)
	{
		i.AddKey(keyNum);
		Debug.Log("boop");
	}

	public bool CheckDoor(int doorNum)
	{
		if(i.CheckIfHaveKey(doorNum))
		{
			return true;
			Debug.Log ("OpenedDoor");
		}
		return false;
	}

	public void LoseGame()
	{
		Debug.Log("Game Over");
	}

	void ChangeLevel()
	{
		Debug.Log("Change Level");
		Application.LoadLevel(levelName);
	}

	public void PauseTimer()
	{
		pauseTimer = true;
	}

	public void UnPauseTimer()
	{
		pauseTimer = false;
	}

}
