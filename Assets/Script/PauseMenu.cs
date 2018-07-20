using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public static bool gamePaused;
	public GameObject pauseMenuUI;
	public GameObject activeScene;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (gamePaused) {
				Resume ();
			} else {
				Pause ();
			}
		}
	}

	public void Resume(){
		pauseMenuUI.SetActive (false);
		activeScene.SetActive (true);
		Time.timeScale = 1f;
		gamePaused = false;
	}
	public void Pause(){
		pauseMenuUI.SetActive (true);
		activeScene.SetActive (false);
		Time.timeScale = 0f;
		gamePaused = true;
	}
	public void LoadMenu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene ("start");
	}
	public void QuitGame(){
		Debug.Log ("Quitting Game...");
		Application.Quit ();
	}
}