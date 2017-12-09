using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour {

	public float speed;
	public float initialHeight, finalHeight;
	public float limitX;
	
	// Update is called once per frame
	void Update () {

		if (FlappyBirdScript.isPlaying) {
			// Move the pipe
			transform.Translate (Vector2.left * speed * Time.deltaTime);

			// Verifies the limit and returns the pipe
			if (transform.position.x <= limitX) {
				transform.position = new Vector2 (limitX * -1, Random.Range (initialHeight, finalHeight));
			}
		}
	}
}
