using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Selecting2 : MonoBehaviour {
	public GameObject btnl,btnr,btn1,btn2,btn3,btn4;
	public GameObject kpk,kpk2;
	public GameObject check;
	public GameObject wrong;
	public GameObject activeScene;
	public InputField numerator;
	public InputField denominator;
	public int num_digit = 0;
	public int den_digit = 0;

	// Use this for initialization
	void Start () {
		btn1.gameObject.SetActive (false);
		btn2.gameObject.SetActive (false);
		btn3.gameObject.SetActive (false);
		btn4.gameObject.SetActive (false);

		check.SetActive (false);
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

	public void KPK1button(){
		btn1.gameObject.SetActive (true);
		btn2.gameObject.SetActive (true);
	}
	public void KPK2button(){
		btn3.gameObject.SetActive (true);
		btn4.gameObject.SetActive (true);
	}

	public void selectingSoal1(){
		btn1.gameObject.SetActive (false);
		btn2.gameObject.SetActive (false);
		kpk.gameObject.SetActive (false);
	}
	public void selectingSoal2(){
		btn3.gameObject.SetActive (false);
		btn4.gameObject.SetActive (false);
		kpk2.gameObject.SetActive (false);
	}
	public void selecting1(){
		btn2.gameObject.SetActive (false);
		btnl.gameObject.SetActive (false);
		kpk.gameObject.SetActive (false);
	}
	public void selecting2(){
		btn1.gameObject.SetActive (false);
		btnl.gameObject.SetActive (false);
		kpk.gameObject.SetActive (false);
	}
	public void selecting3(){
		btn4.gameObject.SetActive (false);
		btnr.gameObject.SetActive (false);
		kpk2.gameObject.SetActive (false);
	}
	public void selecting4(){
		btn3.gameObject.SetActive (false);
		btnr.gameObject.SetActive (false);
		kpk2.gameObject.SetActive (false);
	}

	public void btnEqual(){
		if (num_digit == 1 && den_digit == 4) {
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
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 5);
	}
}
