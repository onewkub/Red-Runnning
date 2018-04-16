using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuckBlock : MonoBehaviour {
	// Use this for initialization
	GameObject player;
	float BlockPositY ,CurrY,HighBlock;
	float SizePosY;
	void Start () {
		player = GameObject.Find ("player");
		SizePosY = GetComponent<BoxCollider2D> ().size.y;
		BlockPositY = transform.position.y + (SizePosY / 2);
		//Debug.Log (BlockPositX);
		
	}
	
	// Update is called once per frame
	void Update () {
		CurrY = player.transform.position.y;
		//Debug.Log (CurrX);
		if(CurrY > BlockPositY){
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
