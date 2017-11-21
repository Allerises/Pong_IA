using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallL2: L2SuperClass {

	private Rigidbody ball;

	void Awake () {
		ball = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Start () {
		ball.velocity = new Vector3 (xVel, yVel, 0);
	}

	void OnTriggerEnter(Collider Other){
		if (Other.tag.Equals ("Player")) {
			print ("Entering");
			xVel = -xVel;
			yVel = -yVel;
			ball.velocity = new Vector3 (xVel, yVel, 0);
			Debug.Log (ball.velocity);
		}
	}
}
