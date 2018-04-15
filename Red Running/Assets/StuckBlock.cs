using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuckBlock : MonoBehaviour {
	// Use this for initialization
	GameObject player;
	float BlockPositX, BlockPositY ,CurrX,CurrY,HighBlock;
	float SizePosX, SizePosY;
	void Start () {
		player = GameObject.Find ("player");
		SizePosX = GetComponent<BoxCollider2D> ().size.x;
		SizePosY = GetComponent<BoxCollider2D> ().size.y;
		BlockPositX = transform.position.x- (SizePosX/2);
		BlockPositY = transform.position.y + (SizePosY / 2);
		//Debug.Log (BlockPositX);
		
	}
	
	// Update is called once per frame
	void Update () {
		CurrX = player.transform.position.x ;
		CurrY = player.transform.position.y;
		Debug.Log (CurrX);
		if (CurrX > BlockPositX) {
			player_controller.isStuck = false;
		}
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
