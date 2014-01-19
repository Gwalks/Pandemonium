using UnityEngine;
using System.Collections;

public class Level1Uni1 : MonoBehaviour {

	Inventory i;
	public int numOfKeys;
	
	// Use this for initialization
	void Start () {
		i = new Inventory(numOfKeys);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI() {
		GUIStyle timeStyle = new GUIStyle();
		timeStyle.fontSize = 20;
		GUI.Label(new Rect(Screen.width - 100,0,50,25),"Time",timeStyle);
	}
	public void AddKey(int keyNum)
	{
		i.AddKey(keyNum);
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

	public void EndGame()
	{
		Debug.Log("Game Over");
	}

}
