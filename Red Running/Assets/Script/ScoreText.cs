using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
	public Text Score;
	float x;
	public static float score;
	GameObject obj;
	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("player");
		score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		x = obj.transform.position.x;
		score = x;
		//Debug.Log (x);
		Score.text = "SCORE: "+score.ToString("f0");
		
	}
}
