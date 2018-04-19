using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_controller : MonoBehaviour {
	public Text speedCounter;
	public Text HighScore;
	public static bool died;
	public GameObject DiedMenu;
	float speedCount;
	Rigidbody2D rb;
	Animator am;
	int n;
	public float speed,jumpforce;
	public static float coin;
	public static bool isStuck;
	AudioSource asource;

	// Use this for initialization
	void Start () {
		HighScore.text = "HIGH SCORE: "+PlayerPrefs.GetFloat ("HighScore", 0f).ToString ("f0");
		coin = 0;
		Time.timeScale = 1f;
		died = false;
		rb = GetComponent<Rigidbody2D> ();
		am = GetComponent<Animator> ();
		am.SetBool ("isruning", true);
		n = 0;
		asource = GetComponent<AudioSource> ();
		asource.volume *= audioController.value;
		isStuck = false;

	}
	
	// Update is called once per frame
	void Update () {
		
		if (!isStuck) {
			rb.velocity = new Vector2 (speed+coin, rb.velocity.y);
			//Debug.Log ("not stuck");
			speedCount = rb.velocity.x;
		} 
		if(isStuck){
			rb.velocity = new Vector2 (0f, rb.velocity.y);
			//Debug.Log ("stuck");
		}
		speedCounter.text = "SPEED x " + (speedCount/5).ToString("f1");
		if (died) {
			Died ();
		}
		if (transform.position.y < -5.5f && !died) {
			died = true;
			//Debug.Log("Died");
		}
		if(!died){
			if (Input.GetButtonDown("Jump") && n < 2) {
				n ++;
				asource.Play ();
				am.SetBool ("isjumping_up", true);
				am.SetBool ("isruning", false);
				//Debug.Log ("Jump!!");
				rb.velocity = new Vector2 (rb.velocity.x, jumpforce);
			}
		}
		if (rb.velocity.y < -1.8f) {
			am.SetBool ("isjumping_up", false);
			am.SetBool ("isjumping_down", true);
			}
		}
	void OnCollisionEnter2D(Collision2D coll) {
		am.SetBool ("isjumping_down", false);
		am.SetBool ("isruning", true);
		n = 0;
		//Debug.Log ("test");
	}
	public void Died()
	{
		Time.timeScale = 0f;
		DiedMenu.SetActive (true);
		//Debug.Log (ScoreText.score);
		if (ScoreText.score > PlayerPrefs.GetFloat ("HighScore", 0f)) {
			PlayerPrefs.SetFloat ("HighScore", ScoreText.score);
			HighScore.text = "HIGH SCORE: " + ScoreText.score.ToString ("f0");

		}
	}
}
