using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MoveBall : L1SuperClass {

	//Variable Declaration
	private Rigidbody rb;
	private bool atStart = true;
	public Text start;
	public Text resume;
    public Text indicator;

	//Initialise game upon loading the level
	void Awake () {
		rb = GetComponent<Rigidbody> ();
		Time.timeScale = 0;
		start.GetComponent<Text>();
		resume.GetComponent<Text>();
        indicator.GetComponent<Text>();
		resume.enabled = false;
	}

	//Start the game
	public void StartGame(){
		if (atStart && !running) {
			rb.velocity = new Vector3 (xVel, yVel, 0);
			running = true;
			atStart = false;
			Time.timeScale = 1;
			start.enabled = false;
            indicator.enabled = false;
		}
	}

	//Restart the game
	public void ResetGame(){
		if (!atStart && !running && Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = new Vector3 (xVel, yVel, 0);
			running = true;
			resume.enabled = false;
		}
	}

	//Performs checks for collisions
	public void OnTriggerEnter(Collider other){
		WallHit (other.tag);
	}

	//Performs collision logic
	public void WallHit(String tag){
		if (tag.Equals ("HWall")) {
			yVel = -yVel;
			rb.velocity = new Vector3(xVel, yVel, 0);
		} else {
			xVel = -xVel;
			rb.velocity = new Vector3(xVel, yVel, 0);
			if (tag.Equals ("Player")) {
				IncrementPoints ();
			} else if(tag.Equals("VWall")){
				running = false;
			}
		}
	}

	//Maintains state of game
	void FixedUpdate(){
		if(Input.GetKey (KeyCode.Space) && atStart){
			StartGame ();
		}
		ResetGame ();
		ballPosition = rb.transform.position;
	}

	//Increments points
	void IncrementPoints(){
		points++;
		if(points % 5 == 0) {
			xVel *= 1.3f;
			if(yVel > 0){
				yVel += .1f;
			} else {
				yVel -= .1f;
			}
			Debug.Log(xVel + ", " + yVel);
			pyVel += 0.5f;
		}
	}
}