using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBg : MonoBehaviour {
	public float bgSpeed;
	float bgPositionX;
	float bg1PositionX;

	// Use this for initialization
	void Start () {
		bgPositionX = transform.position.x;
		bg1PositionX = GameObject.Find ("bg_1").transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x + bgSpeed, transform.position.y, transform.position.z);
		
	}
}
