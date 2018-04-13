using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioController : MonoBehaviour {
	AudioSource asource;
	public Slider sli;
	public static float value = 1f;
	public static float StartVol;

	// Use this for initialization
	void Start () {
		asource = GetComponent<AudioSource> ();
		StartVol = asource.volume;
		sli.value = value;
	}
	
	// Update is called once per frame
	void Update () {
		value = sli.value;
		asource.volume = StartVol*value;
	}
}
