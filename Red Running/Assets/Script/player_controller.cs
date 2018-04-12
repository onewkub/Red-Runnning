using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_controller : MonoBehaviour {
	public Text speedCounter;
	bool died;
	public GameObject DiedMenu;
	float speedCount;
	Rigidbody2D rb;
	Animator am;
	int n;
	public float speed,jumpforce;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		died = false;
		rb = GetComponent<Rigidbody2D> ();
		am = GetComponent<Animator> ();
		am.SetBool ("isruning", true);
		n = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (died) {
			Died ();
		}
		rb.velocity = new Vector2 (speed, rb.velocity.y);
		speedCount = rb.velocity.x;
		speedCounter.text = "SPEED x " + (speedCount/5).ToString("f1");
		if (transform.position.y < -5.5f) {
			died = true;
			//Debug.Log("Died");
		}
		if(!died){
		if (Input.GetButtonDown("Jump") && n <= 1) {
			am.SetBool ("isruning", false);
			am.SetBool ("isjumping_up", true);
			rb.velocity = new Vector2 (rb.velocity.x, jumpforce);
			n ++;
			}
		}
		if (rb.velocity.y < -1.8f) {
			am.SetBool ("isjumping_up", false);
			am.SetBool ("isjumping_down", true);
			//Debug.Log("down");
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
		died = false;
		DiedMenu.SetActive (true);

	}
}
