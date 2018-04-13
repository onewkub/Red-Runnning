using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	public Text HighScoreText;
	void Start(){
		HighScoreText.text = PlayerPrefs.GetFloat ("HighScore", 0f).ToString ("f0");
	}
	void Update(){
		HighScoreText.text = PlayerPrefs.GetFloat ("HighScore", 0f).ToString ("f0");
	}
}
