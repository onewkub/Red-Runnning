using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgfollow : MonoBehaviour {
	public Transform obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (obj.position.x+8f, transform.position.y, transform.position.z);
	}
}
