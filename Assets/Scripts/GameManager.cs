using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

	private bool paused=false;

	public Rotator rotator;
	public Spawner spawner;

	public Animator animator;


	public void EndGame()
	{
		if (gameHasEnded)
			return;

		AudioSource[] sources = this.GetComponents<AudioSource>();
		sources[1].Play();

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
	}

	public void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void NextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}

	public void pause() 
	{
		if (paused == false){
			Time.timeScale = 0.0f;
			rotator.enabled = false;
			rotator.enabled = false;
			paused = true;
		}
		else {
			Time.timeScale = 1.0f;
			rotator.enabled = true;
			rotator.enabled = true;
			paused = false;
		}
		
		
	}

	

}
