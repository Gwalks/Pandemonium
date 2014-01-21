using UnityEngine;	
using System.Collections;
using System.Collections.Generic;

public class StoryScript : MonoBehaviour {
	//GUITexture g;
	public GUITexture[] gt = new GUITexture[3];
	//public ArrayList<string[]> arr = new ArrayList<string[]>();

	Dictionary<int,string[]> arr = new Dictionary<int, string[]>();

	int stringIndex = 0;
	int frameIndex = 0;

	public string[] frame1 = new string[3];
	public string[] frame2 = new string[3];
	public string[] frame3 = new string[3];
	public string[] temp;
	void Awake()
	{
		Screen.SetResolution(1024,768, true);
		arr.Add(0,frame1);
		arr.Add(1,frame2);
		arr.Add(2,frame3);
		temp = arr[0];
	}
	void OnGUI()
	{
		if(stringIndex>=temp.Length)
		{
			if (frameIndex != 2) {
				gt[frameIndex].enabled=false;
			}
			frameIndex++;
			stringIndex = 0;
		}
		GUI.Box(new Rect(0,Screen.height-100, Screen.width, 200),temp[stringIndex]);
	}
	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		if(stringIndex>temp.Length)
		{
			if (frameIndex != 2) {
				gt[frameIndex].enabled=false;
				frameIndex++;
			}
			stringIndex = 0;
		}
		if(frameIndex > gt.Length - 1)
		{
			Application.LoadLevel(2);	
		}
		else
			temp = arr[frameIndex];
		if(Input.GetKeyUp(KeyCode.Return))
		{
			stringIndex++;
			Debug.Log(stringIndex);
		}
	}
}