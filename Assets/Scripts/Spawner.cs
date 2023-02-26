using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour {

	public GameObject pinPrefab;

	public AudioSource pinShoot;

	public GameObject Camera;

	public Color pinColor;


	void start ()
	{
		if(sceneManager.pinRotColor == 1) {
			pinColor = Color.red;
		}
		if (sceneManager.pinRotColor == 2) {
			pinColor = Color.green;
		}
		if (sceneManager.pinRotColor == 2) {
			pinColor = Color.blue;
		}
	}
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			SpawnPin();
		}
		if (Input.GetKeyDown("escape"))
		{
			Camera.GetComponent<GameManager>().pause();
		}
		if (Input.GetKeyDown("end")) {
			Camera.GetComponent<GameManager>().NextLevel();
		}
	}

	void SpawnPin()
	{
		AudioSource[] sources = pinShoot.GetComponents<AudioSource>();
		GameObject pin = Instantiate(pinPrefab, transform.position, transform.rotation) as GameObject;
		if (sceneManager.pinRotColor == 1)
		{
			pin.GetComponent<SpriteRenderer>().color = Color.red;
		}
		if (sceneManager.pinRotColor == 2)
		{
			pin.GetComponent<SpriteRenderer>().color = Color.green; 
		}
		if (sceneManager.pinRotColor == 3)
		{
			pin.GetComponent<SpriteRenderer>().color = Color.blue; 
		}
		sources[2].Play();
		
	}

}
