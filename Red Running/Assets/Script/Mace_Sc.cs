using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace_Sc : MonoBehaviour {
	public float speed;
	Rigidbody2D rb;
	public GameObject DiedMenu;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
		rb.velocity = new Vector2(speed, rb.velocity.y);
		
	}
	public void OnTriggerEnter2D(Collider2D other){
		//Debug.Log (other.name);
		if (other.name == "player") {
			Debug.Log("Hit")	;
			player_controller.died = true;
			//Player.SetActive (false);
		}
	}
}
