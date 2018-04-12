using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
	public Text Score;
	float x;
	public GameObject obj;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		x = obj.transform.position.x;
		//Debug.Log (x);
		Score.text = "SCORE: "+x.ToString("f0");
		
	}
}
