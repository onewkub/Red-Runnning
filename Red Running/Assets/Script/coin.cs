using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	// Use this for initialization
	public void OnTriggerEnter2D(Collider2D other){
		//Debug.Log (other.name);
		if (other.name == "player") {
			player_controller.coin += 1f;
			Debug.Log("Hit")	;
			//Player.SetActive (false);
			Destroy(gameObject);
		}
	}
}
