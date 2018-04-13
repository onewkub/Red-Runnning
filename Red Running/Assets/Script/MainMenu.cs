using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void Play(){
		SceneManager.LoadScene("game");
	}
	public void Quit(){
		Application.Quit ();
	}
	public void HighScore(){
		Debug.Log ("Loding High Score Scene");
	}
	public void Opteion(){
		Debug.Log ("option");
	}

}
