using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coin : MonoBehaviour {
	AudioSource asource;
	void Start(){
		asource = GetComponent<AudioSource> ();
		asource.volume *= audioController.value;
	}
	// Use this for initialization
	public void OnTriggerEnter2D(Collider2D other){
		//Debug.Log (other.name);

		if (other.name == "player") {
			player_controller.coin += 1f;
			asource.Play ();
			Renderer rend = GetComponent<Renderer> ();
			rend.enabled = false;
			//Player.SetActive (false);
			Destroy(gameObject, 0.5f);
		}
	}
}
