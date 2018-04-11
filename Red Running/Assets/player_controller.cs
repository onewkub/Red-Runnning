using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
	Rigidbody2D rb;
	Animator am;
	int n;
	public float speed;
	private float topAngle;
	private float sideAngle;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		am = GetComponent<Animator> ();
		n = 0;
	}
	
	// Update is called once per frame
	void Update () {
		am.SetBool ("isruning", true);
		rb.velocity = new Vector2 (speed, rb.velocity.y);
		if (Input.GetButtonDown("Jump") && n <= 1) {
			am.SetBool ("isruning", false);
			am.SetBool ("isjumping_up", true);
			rb.velocity = new Vector2 (rb.velocity.x, 5f);
			n ++;
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
}
