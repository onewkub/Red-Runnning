using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgfollow : MonoBehaviour {
	Transform obj;

	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("player").transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (obj.position.x+7f, transform.position.y, transform.position.z);
	}
}
