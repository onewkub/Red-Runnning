using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixBlock : MonoBehaviour {
	GameObject player;
	Rigidbody2D rb;
	// Use this for initialization
	void Start(){
		player = GameObject.Find ("player");
		rb = player.GetComponent<Rigidbody2D> ();
	}
	void OnCollisionEnter2D(Collision2D coll) {
		Collider2D collider = coll.collider;
		//Debug.Log (collider.name);
		if (collider.name == "player") {
			rb.velocity = new Vector2 (rb.velocity.x, -25f);
		
		}
	}
}
