using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	// Update is called once per frame
	void Update () {
		//Debug.Log (player_controller.died);
		if (Input.GetKeyDown (KeyCode.Escape) && player_controller.died == false)
		{
			//Debug.Log (player_controller.died);
			if (GameIsPaused) {
				Resume ();
			} else {
				Pause ();
			}
		}
	}
	public void Resume()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;

	}
	void Pause(){
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;

	}
	public void LoadMenu(){
		GameIsPaused = false;
		SceneManager.LoadScene("menu");
		Debug.Log ("Load Menu");
	}
	public void QuitGame(){
		Application.Quit ();
		Debug.Log("Quit Game");

	}

}
