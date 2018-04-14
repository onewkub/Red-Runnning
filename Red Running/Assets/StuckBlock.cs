using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuckBlock : MonoBehaviour {
	// Use this for initialization
	GameObject player;
	float BlockPositX,CurrX;
	float SizePos;
	void Start () {
		player = GameObject.Find ("player");
		SizePos = GetComponent<BoxCollider2D> ().size.x;
		BlockPositX = transform.position.x- (SizePos/2);
		//Debug.Log (BlockPositX);
		
	}
	
	// Update is called once per frame
	void Update () {
		CurrX = player.transform.position.x ;
		Debug.Log (CurrX);
		if (CurrX > BlockPositX) {
			player_controller.isStuck = false;
		}
		
	}
	void OnCollisionEnter2D(Collision2D coll) {
		Collider2D collider = coll.collider;
		//Debug.Log (collider.name);
		if (collider.name == "player") {
			player_controller.isStuck = true;

		}
	}
}
