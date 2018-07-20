using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public GameObject panel;
	public GameObject panel2;

	public void PlayGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame(){
		Debug.Log ("QUIT!!");
		Application.Quit ();
	}

	public void btnHelp(){
		panel.SetActive (true);
		panel2.SetActive (false);
	}

	public void hideHelp(){
		panel.SetActive (false);
		panel2.SetActive (true);
	}
}
