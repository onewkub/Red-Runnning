using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enermy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		Collider2D collider = coll.collider;
		//Debug.Log (collider.name);
		if (collider.name == "player") {
			player_controller.died = true;

		}
}
}
