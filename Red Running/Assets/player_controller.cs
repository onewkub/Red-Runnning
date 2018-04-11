using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
	Rigidbody2D rb;
	Animator am;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		am = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		am.SetBool ("isruning", true);
		rb.velocity = new Vector2 (speed, rb.velocity.y);
		
	}
}
