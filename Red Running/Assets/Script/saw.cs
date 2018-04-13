using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, 5);
		
	}
	void OnCollisionEnter2D(Collision2D coll) {
		Collider2D collider = coll.collider;
		Debug.Log (collider.name);
	}
}
