using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {

	public float pulse;

	//Available for entire game
	public static bool isPlaying;

	//Components
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		// Instantiate components
		rb = GetComponent<Rigidbody2D>();

		// Desenable gravity
		rb.gravityScale = 0.0f;
	}

	
	// Update is called once per frame
	void Update () {

		// Enables gavity
		if (!isPlaying && Input.GetButtonDown("Fire1")) {
			isPlaying = true;
			rb.gravityScale = 1.0f;
		} else if (isPlaying && Input.GetButtonDown("Fire1")){
			rb.velocity = new Vector2 (0.0f, pulse);
		}
	}


	// Detects collision with trigger
	void OnTriggerEnter2D(Collider2D c){
		MainScript.score++;
	}
		
	void OnCollisionEnter2D(Collision2D c){
		SceneManager.LoadScene("start");
	}
}
