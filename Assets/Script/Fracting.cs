using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fracting : MonoBehaviour {
	public GameObject[] slot;
	public GameObject[] slot2;
	public Sprite green;
	public Sprite gray;

	public InputField numer;
	public InputField denom;
	public InputField numerator;
	public InputField denominator;
	public InputField numerator2;
	public InputField denominator2;

	public GameObject check;
	public GameObject wrong;
	public GameObject activeScene;

	public int num1 = 0;
	public int den1 = 0;
	public int num2 = 0;
	public int den2 = 0;
	public int numera = 0;
	public int denomi = 0;

	void Start(){
		numerator.DeactivateInputField ();
		denominator.DeactivateInputField ();

		numerator.text = "" + num1;
		denominator.text = "" + den1;
		numerator2.text = "" + num2;
		denominator2.text = "" + den2;

		check.SetActive (false);
		wrong.SetActive (false);
	}

	public void addNum1(){
		if (num1 < 10) {
			num1 += 1;
			numerator.text = "" + num1;
			slot [num1].GetComponent<Image>().sprite = green;
		}
	}
	public void decNum1(){
		if (num1 > 0) {
			slot [num1].GetComponent<Image>().sprite = gray;
			num1 -= 1;
			numerator.text = "" + num1;
		}
	}
	public void addDen1(){
		if (den1 < 10) {
			den1 += 1;
			denominator.text = "" + den1;
			slot [den1].SetActive (true);
		}
	}
	public void decDen1(){
		if (den1 > 0) {
			den1 -= 1;
			denominator.text = "" + den1;
			slot [den1].SetActive (false);
		}
	}

	public void addNum2(){
		if (num2 < 10) {
			num2 += 1;
			numerator2.text = "" + num2;
			slot2 [num2].GetComponent<Image>().sprite = green;
		}
	}
	public void decNum2(){
		if (num2 > 0) {
			slot2 [num2].GetComponent<Image>().sprite = gray;
			num2 -= 1;
			numerator2.text = "" + num2;
		}
	}
	public void addDen2(){
		if (den2 < 10) {
			den2 += 1;
			denominator2.text = "" + den2;
			slot2 [den2].SetActive (true);
		}
	}
	public void decDen2(){
		if (den2 > 0) {
			den2 -= 1;
			denominator2.text = "" + den2;
			slot2 [den2].SetActive (false);
		}
	}

	public void InputNumer(string num){
		numer.text = num;
		numera = int.Parse (num);
	}
	public void InputDenom(string den){
		denom.text = den;
		denomi = int.Parse (den);
	}

	public void btnCheck(){
		if ((den1 == 6 && den2 == 6) && (num1 == 3 && num2 == 4) && (numera == 3 && denomi == 4)) {
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
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 8);
	}
}
