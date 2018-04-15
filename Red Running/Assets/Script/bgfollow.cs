using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgfollow : MonoBehaviour {
	Transform obj;
	public static bool pass;
	SpriteRenderer rend;
	public GameObject block;
	// Use this for initialization
	void Start () {
		obj = GameObject.Find ("player").transform;
		rend = GetComponent<SpriteRenderer> ();
		//sr = GetComponent<SpriteRenderer> ();
		pass = false;
	}
	
	// Update is called once per frame
	void Update () {
		//tmp.color = new Color(1f, 1f, 1f, 0f);
		//Debug.Log (sr.name);
		if(pass && block.name == bgChange.BlockName){
			startFading ();
			pass = false;
		}
		transform.position = new Vector3 (obj.position.x+7f, transform.position.y, transform.position.z);
	}
	IEnumerator FadeOut(){
		for (float f = 1f; f >= -0.02f; f -= 0.02f) {
			Color c = rend.material.color;
			c.a = f;
			rend.material.color = c;
			yield return new WaitForSeconds (0.02f);
		}
	}
	public void startFading(){
		StartCoroutine ("FadeOut");
	}
}
