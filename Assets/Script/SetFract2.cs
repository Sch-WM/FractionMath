using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetFract2 : MonoBehaviour {
	public GameObject check;
	public GameObject wrong;
	public GameObject activeScene;
	public InputField numerator;
	public InputField denominator;
	public int num_digit = 0;
	public int den_digit = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void InputNum(string num){
		numerator.text = num;
		num_digit = int.Parse (num);
	}
	public void InputDen(string den){
		denominator.text = den;
		den_digit = int.Parse (den);
	}

	public void btnEqual(){
		if (num_digit == 4 && den_digit == 12) {
			check.SetActive (true);
			activeScene.SetActive (false);
			Time.timeScale = 1f;
		} else {
			wrong.SetActive (true);
			activeScene.SetActive (false);
			Time.timeScale = 1f;
		}
	}
	public void next(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
	public void retry(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
	public void menu(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 7);
	}
}
