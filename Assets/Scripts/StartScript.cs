using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start() {
		FlappyBirdScript.isPlaying = false;
	}
	
	// Update is called once per frame
	void Update() {

		if (Input.GetKey(KeyCode.Return) || Input.touchCount == 2) {
			MainScript.score = 0;
			SceneManager.LoadScene("game");
		}
	}
}
