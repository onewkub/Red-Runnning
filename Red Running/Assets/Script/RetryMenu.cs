using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMenu : MonoBehaviour {

	// Use this for initialization
	public void Retry(){
		SceneManager.LoadScene("game");
		Debug.Log ("Retry");
	}
	public void LoadMenu(){
		SceneManager.LoadScene("menu");
		Debug.Log ("Load Menu");
	}
}
