using UnityEngine;	
using System.Collections;
using System.Collections.Generic;

public class StoryScript : MonoBehaviour {
	//GUITexture g;
	public GUITexture[] gt = new GUITexture[3];
	//public ArrayList<string[]> arr = new ArrayList<string[]>();

	Dictionary<int,string[]> arr = new Dictionary<int, string[]>();

	int stringindex=0;
	int index = 0;
	public AudioClip aud;

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
		if(stringindex>=temp.Length)
		{
			gt[index].enabled=false;
			index++;
			stringindex = 0;
		}
		GUI.Box(new Rect(0,Screen.height-100, Screen.width, 200),temp[stringindex]);
	}
	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		if(index >= gt.Length)
		{
			Application.LoadLevel(2);	
		}
		temp = arr[index];
		if(stringindex>=temp.Length)
		{
			gt[index].enabled=false;
			index++;
			stringindex = 0;
		}
		if(Input.GetKeyUp(KeyCode.Return))
		{
			stringindex++;
			audio.PlayOneShot(aud);
		}
	}
}