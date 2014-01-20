using UnityEngine;
using System.Collections;

public class SavePosition : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

}
