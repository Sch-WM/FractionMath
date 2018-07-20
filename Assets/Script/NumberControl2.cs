using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberControl2 : MonoBehaviour {
	public InputField qnumerator;
	public InputField qdenominator;
	public InputField numerator;
	public InputField denominator;
	public int num_digit = 0;
	public int den_digit = 0;
	public GameObject check;
	public GameObject wrong;
	public GameObject activeScene;
	public GameObject[] slot;
	public Sprite green;
	public Sprite gray;

	// Use this for initialization
	void Start () {
		numerator.DeactivateInputField ();
		denominator.DeactivateInputField ();

		qnumerator.text = "1";
		qdenominator.text = "3";

		numerator.text = "" + num_digit;
		denominator.text = "" + den_digit;

		check.SetActive (false);
		wrong.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		numerator.DeactivateInputField ();
		denominator.DeactivateInputField ();
	}

	public void btnPlusNum(){
		if (num_digit < 10) {
			num_digit += 1;
			numerator.text = "" + num_digit;
			slot [num_digit].GetComponent<Image>().sprite = green;
		}
	}
	public void btnMinNum(){
		if (num_digit > 0) {
			slot [num_digit].GetComponent<Image>().sprite = gray;
			num_digit -= 1;
			numerator.text = "" + num_digit;
		}
	}
	public void btnPlusDen(){
		if (den_digit < 10) {
			den_digit += 1;
			denominator.text = "" + den_digit;
			slot [den_digit].SetActive (true);
		}
	}
	public void btnMinDen(){
		if (den_digit > 0) {
			den_digit -= 1;
			denominator.text = "" + den_digit;
			slot [den_digit].SetActive (false);	
		}
	}
	public void btnEqual(){
		if (num_digit == 2 && den_digit == 6) {
			check.SetActive (true);
			activeScene.SetActive (false);
			Time.timeScale = 1f;
		} else if (num_digit == 3 && den_digit == 9) {
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
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
	}
}

