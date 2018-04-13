using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
	Transform obj;
	AudioSource asource;
	float startVol;
	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("player").transform;
		asource = GetComponent<AudioSource> ();
		startVol = asource.volume;
		asource.volume = startVol * audioController.value;
		startVol = asource.volume;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (obj.position.x+7f, transform.position.y, transform.position.z);
		if (player_controller.died) {
			asource.volume = startVol*0.1f;
			
		}
		
	}
}
