using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClick : MonoBehaviour {
	AudioSource asource;
	float startVol;
	void Start(){
		asource = GetComponent<AudioSource> ();
		startVol = asource.volume;

	}
	void Update(){
		asource.volume = startVol * audioController.value;
	}
	public void ClickOn(){
		asource.Play ();
	}
}
