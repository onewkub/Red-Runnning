using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace_Sc : MonoBehaviour {
	public float speed;
	Rigidbody2D rb;
	public GameObject Player;
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
	void OnCollisionEnter2D(Collision2D coll) {
		Collider2D collider = coll.collider;
		Debug.Log (collider.name);
		Destroy (collider);
		//Debug.Log ("test");
	}
	public void OnTriggerEnter2D(Collider2D other){
		//Debug.Log (other.name);
		if (other.name == "player") {
			Debug.Log("Hit")	;
			Player.SetActive (false);
			Died ();
		}
	}
	public void Died()
	{
		Time.timeScale = 0f;
		DiedMenu.SetActive (true);
		return;

	}
}
