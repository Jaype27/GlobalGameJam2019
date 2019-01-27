using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour {

	public GameManager _gm;
	public PlayerControls _pc;
	public GameObject _gameOverScreen;
	public GameObject _pauseScreen;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PauseGame() {
		Time.timeScale = 0;
		_pauseScreen.gameObject.SetActive(true);
	}

	public void ResumeGame() {
		Time.timeScale = 1;
		_pauseScreen.gameObject.SetActive(false);
	}


	public void PlayAgain() {
		_gameOverScreen.gameObject.SetActive(false);
		_gm._lives = 3;
		_gm.CheckSpawn();
		
	}

	public void QuitGame() {
		Application.Quit();
	}
}
