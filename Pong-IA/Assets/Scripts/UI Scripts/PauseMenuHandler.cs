using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuHandler : MonoBehaviour {

	public Canvas canvas;

	void Awake() {
		canvas.GetComponent<Canvas> ();
		canvas.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			canvas.enabled = !canvas.isActiveAndEnabled;
		}
		if (canvas.enabled) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
	}

	public void OnClickResume () {
		canvas.enabled = false;
	}

	public void OnClickQuit () {
		SceneManager.LoadScene ("MainMenu");
	}
}
