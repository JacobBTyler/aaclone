using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float speed = 100f * sceneManager.rotatorSpeed;

	public static Color theColor;


	void Update()
	{
		transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}

	void Start()
	{
		
		if (sceneManager.pinRotColor == 1)
		{
			GameObject.Find("Rotator").GetComponent<SpriteRenderer>().color = Color.red;
		}
		if (sceneManager.pinRotColor == 2)
		{
			GameObject.Find("Rotator").GetComponent<SpriteRenderer>().color = Color.green; 
		}
		if (sceneManager.pinRotColor == 3)
		{
			GameObject.Find("Rotator").GetComponent<SpriteRenderer>().color = Color.blue; 
		}

	}

}
