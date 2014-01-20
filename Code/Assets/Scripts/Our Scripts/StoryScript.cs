using UnityEngine;
using System.Collections;

public class StoryScript : MonoBehaviour {
	GUITexture g;
	void Awake()
	{
		Screen.SetResolution(1024,768, true);
	}
	void OnGui()
	{
		GUI.Box(new Rect(0,Screen.height-100, Screen.width, 200),"Text");
	}
	// Use this for initialization
	void Start () {
		g = GetComponent<GUIElement>().guiTexture;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.E))
		{
			if(g.tag!= "ThirdStory")
			{
				g.color = Color.black;
				g.enabled = false;
			}
		}
	}
}
